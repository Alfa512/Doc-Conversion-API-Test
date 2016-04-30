using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Configuration = IO.Swagger.Client.Configuration;

namespace CSharp.Api.Client.Web.FileApiServices
{
    public struct UploadParams
    {
        public UploadParams(UploadParams parameters)
        {
            Config = parameters.Config;
            FileName = parameters.FileName;
            FileType = parameters.FileType;
            Offset = parameters.Offset;
            Count = parameters.Count;
            Threads = parameters.Threads;
            FileNumber = parameters.FileNumber;
        }

        public Configuration Config;
        public string FileName;
        public string FileType;
        public int Offset;
        public int Count;
        public int Threads;
        public int FileNumber;
    }

    public class UploadThread
    {
        readonly Thread thread;
        private readonly FileApiFunctions _callApiFunctions;

        public UploadThread(string name, UploadParams parameters)
        {
            _callApiFunctions = new FileApiFunctions();
            thread = new Thread(Func);
            thread.Name = name;
            thread.Start(parameters);
        }

        void Func(object parameters)
        {
            var timer = new Stopwatch();
            //Stream outFileStream = new FileStream(ConfigurationManager.AppSettings["SourcePath"]  + Thread.CurrentThread.Name + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //var outFile = new StreamWriter(outFileStream);
            var data = new UploadParams((UploadParams)parameters);
            
            timer = Stopwatch.StartNew();
            _callApiFunctions.UploadFiles(data.Config, data.FileName, data.FileType, data.Offset, data.Count);
            timer.Stop();
            //outFile.Write(Thread.CurrentThread.Name + " executing time: " + timer.ElapsedMilliseconds + " \n\n");
            //outFile.Write("Average upload time for file: " + timer.ElapsedMilliseconds / data.Count + "\n");
            Thread.Sleep(0);
            //outFile.Close();
            //outFileStream.Close();
        }
    }
}