using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Configuration = IO.Swagger.Client.Configuration;

namespace CSharp.Api.Client.Web.PptApiServices
{
    public struct PptViewPdfParams
    {
        public PptViewPdfParams(PptViewPdfParams parameters)
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
    
    public class PptToPdfThread
    {
        readonly Thread thread;
        private readonly PptApiFunctions _pptApiFunctions;

        public PptToPdfThread(string name, PptViewPdfParams parameters)
        {
            _pptApiFunctions = new PptApiFunctions();
            thread = new Thread(Func);
            thread.Name = name;
            thread.Start(parameters);
        }

        void Func(object parameters)
        {
            var timer = new Stopwatch();
            if (!Directory.Exists(ConfigurationManager.AppSettings["SourcePath"] + "metrics/"))
                Directory.CreateDirectory(ConfigurationManager.AppSettings["SourcePath"] + "metrics/");

            Stream outFileStream = new FileStream(ConfigurationManager.AppSettings["SourcePath"] + "metrics/" + Thread.CurrentThread.Name + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var outFile = new StreamWriter(outFileStream);
            var data = new PptViewPdfParams((PptViewPdfParams)parameters);

            timer = Stopwatch.StartNew();
            _pptApiFunctions.PdfViewer(data.Config, data.SourceFileName, data.SourceFileType, data.ResultFileName, data.ResultFileType, data.Offset, data.Count);
            timer.Stop();
            outFile.Write(Thread.CurrentThread.Name + " executing time: " + timer.ElapsedMilliseconds + " \n\n");
            outFile.Write("Average upload time for file: " + timer.ElapsedMilliseconds / data.Count + "\n");
            Thread.Sleep(0);
            outFile.Close();
            //outFileStream.Close();
        }
    }
}