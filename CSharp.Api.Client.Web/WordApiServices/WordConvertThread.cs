using System.Diagnostics;
using System.IO;
using System.Threading;
using CSharp.Api.Client.Web.FileApiServices;
using IO.Swagger.Client;

namespace CSharp.Api.Client.Web.WordApiServices
{
    public struct ConvertParams
    {
        public ConvertParams(ConvertParams parameters)
        {
            Config = parameters.Config;
            ResultFileName = parameters.ResultFileName;
            FileType = parameters.FileType;
            Format = parameters.Format;
            Count = parameters.Count;
            FileNumber = parameters.FileNumber;
        }

        public Configuration Config;
        public string ResultFileName;
        public string FileType;
        public string Format;
        public int Count;
        public int FileNumber;
    }
    
    public class WordConvertThread
    {
        readonly Thread thread;
        private readonly WordApiFunctions _wordApiFunctions;

        public WordConvertThread(string name, ConvertParams parameters)
        {
            _wordApiFunctions = new WordApiFunctions();
            thread = new Thread(Func);
            thread.Name = name;
            thread.Start(parameters);
        }

        void Func(object parameters)
        {
            var timer = new Stopwatch();
            Stream outFileStream = new FileStream("C:/docconversion/" + Thread.CurrentThread.Name + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var outFile = new StreamWriter(outFileStream);
            var data = new ConvertParams((ConvertParams)parameters);

            timer = Stopwatch.StartNew();
            _wordApiFunctions.ConvertToPdf(data.Config, data.ResultFileName, data.FileType, data.Format, data.Count);
            timer.Stop();
            outFile.Write(Thread.CurrentThread.Name + " executing time: " + timer.ElapsedMilliseconds + " \n\n");
            outFile.Write("Average upload time for file: " + timer.ElapsedMilliseconds / 500 + "\n");
            Thread.Sleep(0);
            outFile.Close();
            //outFileStream.Close();
        }
    }
}