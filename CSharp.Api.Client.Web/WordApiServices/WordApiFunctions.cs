using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using IO.Swagger.Api;
using Configuration = IO.Swagger.Client.Configuration;

namespace CSharp.Api.Client.Web.WordApiServices
{
    public class WordApiFunctions
    {
        public void ConvertToPdf(Configuration config, string resultFileName, string fileType, string format, int count)
        {
            var WordApi = new WordApi(config);
            Stream file = new FileStream(resultFileName, FileMode.Open, FileAccess.ReadWrite);
            Stream outFileStream = new FileStream("C:/docconversion/" + resultFileName + "_Metric.txt", FileMode.OpenOrCreate, FileAccess.Write);

            var outFile = new StreamWriter(outFileStream);
            var timer = new Stopwatch();

            for (var i = 0; i < count; i++)
            {
                file.Seek(0, SeekOrigin.Begin);
                var response = WordApi.WordConvertPostWithHttpInfo("ConvDocFile_" + i + ".docx", "PDF", file);
                if (response.StatusCode >= 200 && response.StatusCode <= 205)
                {
                    var pdfResponse = WordApi.WordConvertToPDFWithHttpInfo("ConvDocFile_" + i + ".docx", "ConvDocFile_" + i + ".pdf");
                    if (pdfResponse.Data != null && pdfResponse.StatusCode >= 200 && pdfResponse.StatusCode <= 205)
                    {
                        outFile.WriteLine(response.Data + "\n");
                    }
                    Console.WriteLine("File " + i + " upload success!");
                }
                else
                {
                    Console.WriteLine("File upload failed!");
                }
            }
            file.Close();
            outFile.Close();
        }

        public void PdfViewer(Configuration config, string sourceFileName, string sourceFileType, string resultFileName, string resultfileType, int offset, int count)
        {
            var WordApi = new WordApi(config);
            if (!Directory.Exists(ConfigurationManager.AppSettings["SourcePath"] + "metrics/"))
                Directory.CreateDirectory(ConfigurationManager.AppSettings["SourcePath"] + "metrics/");

            Stream outFileStream = new FileStream(ConfigurationManager.AppSettings["SourcePath"] + "metrics/" + resultFileName + "_" + resultfileType + "_" + offset/count + "_Metric.txt", FileMode.OpenOrCreate, FileAccess.Write);

            var outFile = new StreamWriter(outFileStream);
            var timer = new Stopwatch();

            for (var i = offset; i < offset + count; i++)
            {
                var response = WordApi.WordConvertToPDFWithHttpInfo(Path.GetFileNameWithoutExtension(sourceFileName) + /*"_" + i +*/ Path.GetExtension(sourceFileName) + sourceFileType, Path.GetFileNameWithoutExtension(resultFileName) + "_" + i + Path.GetExtension(resultFileName) + resultfileType);
                if (response.StatusCode >= 200 && response.StatusCode <= 205)
                {
                    //var pdfResponse = WordApi.WordConvertToPDFWithHttpInfo(sourceFileName + "_" + i + "." + sourceFileType, resultFileName + "_" + i + "." + resultfileType);
                    if (response.Data != null && response.StatusCode >= 200 && response.StatusCode <= 205)
                    {
                        var data = response.Data.Replace("\"", "");
                        outFile.WriteLine(data + "\n\n");
                        Console.WriteLine(sourceFileName + "_" + i + "." + sourceFileType + " view success!");
                    }
                    else
                    {
                        outFile.WriteLine(sourceFileName + "_" + i + "." + sourceFileType + " view failed!");
                        Console.WriteLine(sourceFileName + "_" + i + "." + sourceFileType + " view failed!");
                    }
                }
                else
                {
                    Console.WriteLine("File view failed!");
                }
            }
            Console.WriteLine("\n\nAll " + sourceFileType + " files converted successfully!");
            outFile.Close();
        }
    }
}