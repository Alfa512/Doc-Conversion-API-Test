using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using IO.Swagger.Api;
using Configuration = IO.Swagger.Client.Configuration;

namespace CSharp.Api.Client.Web.FileApiServices
{
    public class FileApiFunctions
    {
        public void UploadFiles(Configuration config, string fileName, string fileType, int offset, int count)
        {
            var fileApi = new FileApi(config);
            try
            {
                if (!Directory.Exists(ConfigurationManager.AppSettings["SourcePath"] + "metrics/"))
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["SourcePath"] + "metrics/");
                Stream file = new FileStream(fileName + fileType, FileMode.Open, FileAccess.Read);
                Stream outFileStream = new FileStream(ConfigurationManager.AppSettings["SourcePath"] + "metrics/" + Path.GetFileName(fileName) + "-" + fileType + "_" + offset / count + "_" + DateTime.Now.Ticks + "_Metric.txt", FileMode.OpenOrCreate, FileAccess.Write);

                var outFile = new StreamWriter(outFileStream);
                var timer = new Stopwatch();
                for (var i = offset; i < offset + count; i++)
                {
                    file.Seek(0, SeekOrigin.Begin);
                    timer = Stopwatch.StartNew();
                    var response = fileApi.FileUploadPostWithHttpInfo(Path.GetFileNameWithoutExtension(fileName) + "_" + i + Path.GetExtension(fileName) + fileType, file);
                    if (response.StatusCode > 200 && response.StatusCode < 205)
                    {
                        timer.Stop();
                        outFile.Write("Uploading time: " + timer.ElapsedMilliseconds + ", " + Path.GetFileNameWithoutExtension(fileName) + "_" + i + Path.GetExtension(fileName) + fileType + "\n\n");
                        Console.WriteLine(Path.GetFileNameWithoutExtension(fileName) + "_" + i + Path.GetExtension(fileName) + fileType + " upload success!");
                    }
                    else
                    {
                        Console.WriteLine("File upload failed!");
                    }
                    if (response.Data != null)
                    {
                        var a = response.Data;
                    }
                }

                Console.WriteLine("\n\nAll files uploaded successfully!");

                file.Close();
                outFile.Close();
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.Message + "\n");
                //Console.WriteLine("File create failed. No such directory or access failure.\n");
            }

            
        }

        public void DownloadFiles(Configuration config, string fileName, string fileType, int offset = 0, int count = 0)
        {
            try
            {
                var fileApi = new FileApi(config);
                Stream file = new FileStream(ConfigurationManager.AppSettings["SourcePath"] + fileName + "." + fileType, FileMode.Open, FileAccess.Read);
                Stream outFileStream;// = new FileStream("C:/docconversion/downloads/" + fileName + "." + fileType, FileMode.OpenOrCreate, FileAccess.Write);
                Stream metricFileStream = new FileStream(ConfigurationManager.AppSettings["SourcePath"] + "metrics/" + fileName + "-" + fileType + "_" + offset / count + "_Metric.txt", FileMode.OpenOrCreate, FileAccess.Write);
                var outFile = new StreamWriter(metricFileStream);

                var timer = new Stopwatch();
                if (count > 0)
                {
                    for (var i = offset; i < offset + count; i++)
                    {
                        //file.Seek(0, SeekOrigin.Begin);
                        timer = Stopwatch.StartNew();
                        var response = fileApi.FileDownloadToStreamWithHttpInfo(fileName + "_" + i + "." + fileType);
                        if (response != null && response.Data != null && response.StatusCode >= 200 && response.StatusCode <= 205)
                        {
                            timer.Stop();
                            outFileStream = new FileStream(ConfigurationManager.AppSettings["SourcePath"] + "downloads/" + fileName + "_" + i + "." + fileType, FileMode.OpenOrCreate, FileAccess.Write);
                            response.Data.CopyTo(outFileStream);
                            outFileStream.Close();
                            outFile.Write("Uploading time: " + timer.ElapsedMilliseconds + ", " + fileName + "_" + i + "." + fileType + "\n\n");
                            Console.WriteLine(fileName + "_" + i + "." + fileType + " download success!");
                        }
                        else
                        {
                            Console.WriteLine("File upload failed!");
                        }
                        if (response.Data != null)
                        {
                            var a = response.Data;
                        }
                    }
                }
                else
                {
                    outFileStream = new FileStream(ConfigurationManager.AppSettings["SourcePath"] + "downloads/" + fileName + "." + fileType, FileMode.OpenOrCreate, FileAccess.Write);
                    var response = fileApi.FileDownloadToStreamWithHttpInfo(fileName + "." + fileType);
                    if (response?.Data != null)
                    {
                        response.Data.CopyTo(outFileStream);
                    }
                    outFileStream.Close();
                }

                outFile.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("File create failed. No such directory or access failure.\n");

                throw;

            }

        }
    }
}