using System.Diagnostics;
using System.IO;
using System.Threading;
using IO.Swagger.Client;

namespace CSharp.Api.Client.Web.FileApiServices
{
    public struct DownloadParams
    {
        public DownloadParams(DownloadParams parameters)
        {
            Config = parameters.Config;
            FileName = parameters.FileName;
            FileType = parameters.FileType;
            Offset = parameters.Offset;
            Count = parameters.Count;
            FileNumber = parameters.FileNumber;
        }

        public Configuration Config;
        public string FileName;
        public string FileType;
        public int Offset;
        public int Count;
        public int FileNumber;
    }

    public class DownloadThread
    {
        readonly Thread thread;
        private readonly FileApiFunctions _callApiFunctions;

        public DownloadThread(string name, DownloadParams parameters)
        {
            _callApiFunctions = new FileApiFunctions();
            thread = new Thread(Func);
            thread.Name = name;
            thread.Start(parameters);
        }

        void Func(object parameters)
        {
            var timer = new Stopwatch();
            Stream outFileStream = new FileStream("C:/docconversion/" + Thread.CurrentThread.Name + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var outFile = new StreamWriter(outFileStream);
            var data = new DownloadParams((DownloadParams)parameters);

            timer = Stopwatch.StartNew();
            _callApiFunctions.DownloadFiles(data.Config, data.FileName, data.FileType, data.Offset, data.Count);
            timer.Stop();
            outFile.Write(Thread.CurrentThread.Name + " executing time: " + timer.ElapsedMilliseconds + " \n\n");
            if (data.Count == 0)
                outFile.Write("Average download time for file: " + timer.ElapsedMilliseconds / 1 + "\n");
            else
                outFile.Write("Average download time for file: " + timer.ElapsedMilliseconds / data.Count + "\n");
            Thread.Sleep(0);
            outFile.Close();
            //outFileStream.Close();
        }
    }
}