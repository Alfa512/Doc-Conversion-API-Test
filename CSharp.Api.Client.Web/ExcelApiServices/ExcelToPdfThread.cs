using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading;
using CSharp.Api.Client.Web.WordApiServices;
using Configuration = IO.Swagger.Client.Configuration;

namespace CSharp.Api.Client.Web.ExcelApiServices
{
    public struct ExcelViewPdfParams
    {
        public ExcelViewPdfParams(ExcelViewPdfParams parameters)
        {
            Config = parameters.Config;
            SourceFileName = parameters.SourceFileName;
            SourceFileType = parameters.SourceFileType;
            ResultFileName = parameters.ResultFileName;
            ResultFileType = parameters.ResultFileType;
            Offset = parameters.Offset;
            Count = parameters.Count;
            FileNumber = parameters.FileNumber;
        }

        public Configuration Config;
        public string SourceFileName;
        public string SourceFileType;
        public string ResultFileName;
        public string ResultFileType;
        public int Offset;
        public int Count;
        public int FileNumber;
    }
    
    public class ExcelToPdfThread
    {
        readonly Thread thread;
        private readonly ExcelApiFunctions _excelApiFunctions;

        public ExcelToPdfThread(string name, ExcelViewPdfParams parameters)
        {
            _excelApiFunctions = new ExcelApiFunctions();
            thread = new Thread(Func);
            thread.Name = name;
            thread.Start(parameters);
        }

        void Func(object parameters)
        {
            var timer = new Stopwatch();
            Stream outFileStream = new FileStream(ConfigurationManager.AppSettings["SourcePath"] + "metrics/" + Thread.CurrentThread.Name + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var outFile = new StreamWriter(outFileStream);
            var data = new ExcelViewPdfParams((ExcelViewPdfParams)parameters);

            timer = Stopwatch.StartNew();
            _excelApiFunctions.PdfViewer(data.Config, data.SourceFileName, data.SourceFileType, data.ResultFileName, data.ResultFileType, data.Offset, data.Count);
            timer.Stop();
            outFile.Write(Thread.CurrentThread.Name + " executing time: " + timer.ElapsedMilliseconds + " \n\n");
            outFile.Write("Average upload time for file: " + timer.ElapsedMilliseconds / data.Count + "\n");
            Thread.Sleep(0);
            outFile.Close();
            //outFileStream.Close();
        }
    }
}