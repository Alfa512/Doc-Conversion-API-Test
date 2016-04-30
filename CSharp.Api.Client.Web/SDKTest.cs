using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using CSharp.Api.Client.Domain.Enums;
using CSharp.Api.Client.Web.ExcelApiServices;
using CSharp.Api.Client.Web.FileApiServices;
using CSharp.Api.Client.Web.PptApiServices;
using CSharp.Api.Client.Web.WordApiServices;
using IO.Swagger.Client;
using Microsoft.Win32.SafeHandles;
using Configuration = IO.Swagger.Client.Configuration;

namespace CSharp.Api.Client.Web
{
    public class SDKTest
    {
        /* Console */
        [DllImport("kernel32.dll",
            EntryPoint = "GetStdHandle",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetStdHandle(int nStdHandle);
        [DllImport("kernel32.dll",
            EntryPoint = "AllocConsole",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();
        private const int STD_OUTPUT_HANDLE = -11;
        private const int MY_CODE_PAGE = 437;
        /* Console */

        private readonly Configuration _config;

        public SDKTest()
        {
            var apiKey = new Dictionary<string, string>()
            {
                {"AppSecret", ConfigurationManager.AppSettings["AppSecret"]},
                {"AppId", ConfigurationManager.AppSettings["AppId"]}
            };

            _config = new Configuration(apiKey: apiKey);
            _config.ApiClient = new ApiClient(_config);

            if (!Directory.Exists(ConfigurationManager.AppSettings["SourcePath"]))
                Directory.CreateDirectory(ConfigurationManager.AppSettings["SourcePath"]);

            if (!Directory.Exists(ConfigurationManager.AppSettings["SourcePath"] + "metrics/"))
                Directory.CreateDirectory(ConfigurationManager.AppSettings["SourcePath"] + "metrics/");


        }

        public string Start()
        {
            var commands = "\nup - Upload files.\n" +
                           "\ndown - Download files\n" +
                           "\npdfcnv - Convert file to PDF\n" +
                           "\nviewpdf - View file as PDF\n" +
                           "\nviewpdfa - View DOCX, XLSX, PPTX files as PDF with same name\n" +
                           "\n";

            Console.WriteLine(commands);
            Console.Write("Enter command :> ");
            string input = Console.ReadLine();
            var inputn = "";

            var parameters = new UploadParams();

            switch (input)
            {
                case "up":
                    Console.WriteLine("\nFile name: ");
                    inputn = Console.ReadLine();
                    UploadFiles(CallType.Console, inputn);
                    Console.WriteLine("Upload success!");
                    break;
                case "down":
                    inputn = Console.ReadLine();
                    DownloadFiles(CallType.Console, inputn);
                    Console.WriteLine("Download success!");
                    break;
                case "pdfcnv":
                    inputn = Console.ReadLine();
                    ConvertToPDF(CallType.Console, inputn);
                    Console.WriteLine("Convert success!");
                    break;
                case "viewpdfw":
                    inputn = Console.ReadLine();
                    parameters.FileName = inputn;
                    ViewPDF(CallType.Console, parameters);
                    Console.WriteLine("Convert success!");
                    break;
                case "viewpdfx":
                    inputn = Console.ReadLine();
                    parameters.FileName = inputn;
                    ViewPDF(CallType.Console, parameters);
                    Console.WriteLine("Convert success!");
                    break;
                case "viewpdfp":
                    inputn = Console.ReadLine();
                    parameters.FileName = inputn;
                    ViewPDF(CallType.Console, parameters);
                    Console.WriteLine("Convert success!");
                    break;
                case "viewpdfa":
                    inputn = Console.ReadLine();
                    parameters.FileName = inputn;
                    ViewPDF(CallType.Console, parameters);
                    ViewPDF(CallType.Console, parameters);
                    ViewPDF(CallType.Console, parameters);
                    Console.WriteLine("Convert success!");
                    break;
                case "exit":
                    return input;
            }

            return "";
        }

        public string UploadFiles(CallType callType, string fileName = "file", int count = 1, int threads = 1)
        {
            InitConsole();

            var consoleOut = new StringWriter();
            var consoleOut1 = Console.Out;
            //Console.SetOut(consoleOut);
            string name;
            string ext;
            if (callType == CallType.Console)
            {
                name = ConfigurationManager.AppSettings["SourcePath"] + Path.GetFileNameWithoutExtension(fileName); ;
                ext = !string.IsNullOrEmpty(Path.GetExtension(fileName)) ? Path.GetExtension(fileName) : "docx";
            }
            else
            {
                name = fileName;
                ext = "";
            }

            var total = count;
            var offset = total / threads;
            var parameters = new UploadParams
            {
                Offset = 0,
                Count = offset,
                Config = _config,
                FileName = name,
                FileType = ext
            };

            for (int i = 0; i < threads; i++)
            {
                parameters.Offset = i * offset;
                var upload = new UploadThread("THREAD " + i + ", Upload of " + offset + name + ext, parameters);
            }

            //var parametersXlsx = new UploadParams
            //{
            //    Offset = 0,
            //    Count = offset,
            //    Config = _config,
            //    FileName = name,
            //    FileType = "xlsx"
            //    //FileType = !string.IsNullOrEmpty(ext) ? ext : "xlsx"
            //};

            //for (int i = 0; i < threads; i++)
            //{
            //    parametersXlsx.Offset = i * offset;
            //    var uploadXlsx = new UploadThread("THREAD " + i + ", View PDF of " + offset + " XLSX", parametersXlsx);
            //}

            //var parametersPptx = new UploadParams
            //{
            //    Offset = 0,
            //    Count = offset,
            //    Config = _config,
            //    FileName = name,
            //    FileType = "pptx"
            //    //FileType = !string.IsNullOrEmpty(ext) ? ext : "pptx"
            //};

            //for (int i = 0; i < threads; i++)
            //{
            //    parametersPptx.Offset = i * offset;
            //    var uploadPptx = new UploadThread("THREAD " + i + ", View PDF of " + offset + " PPTX", parametersPptx);
            //}
            return "Upload success!";
            return consoleOut1.ToString();
            return consoleOut.ToString();
        }

        string DownloadFiles(CallType callType, string fileName = "file", int count = 1, int threads = 1)
        {
            InitConsole();

            string name;
            string ext;

            if (callType == CallType.Console)
            {
                name = ConfigurationManager.AppSettings["SourcePath"] + Path.GetFileNameWithoutExtension(fileName); ;
                ext = !string.IsNullOrEmpty(Path.GetExtension(fileName)) ? Path.GetExtension(fileName) : "docx";
            }
            else
            {
                name = fileName;
                ext = "";
            }

            var total = count;
            var offset = total / threads;
            var parameters = new DownloadParams
            {
                Offset = 0,
                Count = offset,
                Config = _config,
                FileName = name,
                FileType = ext
            };

            //var download = new DownloadThread("THREAD " + 0 + ", View PDF of " + offset + " DOCX", parameters);

            for (int i = 0; i < threads; i++)
            {
                parameters.Offset = i * offset;
                var download = new DownloadThread("THREAD " + i + ", Download of " + offset + " DOCX", parameters);
            }
            return "Download success!";

        }

        string ConvertToPDF(CallType callType, string fileName = "file", int count = 1, int threads = 1)
        {
            InitConsole();

            string name;
            string ext;

            if (callType == CallType.Console)
            {
                name = ConfigurationManager.AppSettings["SourcePath"] + Path.GetFileNameWithoutExtension(fileName); ;
                ext = !string.IsNullOrEmpty(Path.GetExtension(fileName)) ? Path.GetExtension(fileName) : "docx";
            }
            else
            {
                name = fileName;
                ext = "";
            }

            var parametersDocx = new ConvertParams
            {
                Count = count,
                Config = _config,
                ResultFileName = name,
                FileType = ext
            };

            var total = count;
            var offset = total / threads;
            var parameters = new DownloadParams
            {
                Offset = 0,
                Count = offset,
                Config = _config,
                FileName = name,
                FileType = ext
            };

            for (int i = 0; i < threads; i++)
            {
                parameters.Offset = i * offset;
                var uploadDocx1 = new WordConvertThread("Convert DOCX", parametersDocx);
            }
            return "Convert success!";

            //var parametersXlsx = new ConvertParams
            //{
            //    Count = 500,
            //    Config = _config,
            //    ResultFileName = "New",
            //    FileType = "xlsx"
            //};
            //var parametersPptx = new ConvertParams
            //{
            //    Count = 500,
            //    Config = _config,
            //    ResultFileName = "New",
            //    FileType = "pptx"
            //};

            //var uploadDocx1 = new WordConvertThread("Convert first 500 DOCX", parametersDocx);
            //parametersDocx.ResultFileName = "New1";
            //var uploadDocx2 = new WordConvertThread("Convert second 500 DOCX", parametersDocx);
            //parametersDocx.ResultFileName = "New2";
            //var uploadDocx3 = new WordConvertThread("Convert third 500 DOCX", parametersDocx);

            //var uploadXlsx1 = new WordConvertThread("Convert first 500 XLSX", parametersXlsx);
            //parametersXlsx.ResultFileName = "New1";
            //var uploadXlsx2 = new WordConvertThread("Convert second 500 XLSX", parametersXlsx);
            //parametersXlsx.ResultFileName = "New2";
            //var uploadXlsx3 = new WordConvertThread("Convert third 500 XLSX", parametersXlsx);

            //var uploadPptx1 = new WordConvertThread("Convert first 500 PPTX", parametersPptx);
            //parametersPptx.ResultFileName = "New1";
            //var uploadPptx2 = new WordConvertThread("Convert second 500 PPTX", parametersPptx);
            //parametersPptx.ResultFileName = "New2";
            //var uploadPptx3 = new WordConvertThread("Convert third 500 PPTX", parametersPptx);
        }

        public string ViewPDF(CallType callType, UploadParams parameters)
        {
            InitConsole();

            string name;
            string ext;

            if (callType == CallType.Console)
            {
                name = ConfigurationManager.AppSettings["SourcePath"] + Path.GetFileNameWithoutExtension(parameters.FileName); ;
                ext = !string.IsNullOrEmpty(Path.GetExtension(parameters.FileName)) ? Path.GetExtension(parameters.FileName) : "docx";
            }
            else
            {
                name = parameters.FileName;
                ext = "";
            }

            var total = parameters.Count;
            var offset = total / parameters.Threads;
            var parameter = new DownloadParams
            {
                Offset = 0,
                Count = offset,
                Config = _config,
                FileName = name,
                FileType = ext
            };

            parameters.Config = _config;

            switch (ext == "" ? Path.GetExtension(parameters.FileName).Remove(0,1) : ext)
            {
                case "docx":
                case "doc":
                case "docm":
                case "dot":
                case "dotm":
                case "dotx":
                case "odt":
                case "rtf":
                    ConvertWordToPdf(name, ext, parameters.Count, parameters.Threads);
                    break;
                case "xls":
                case "xlsx":
                case "xlsm":
                case "xlsb":
                case "xml":
                case "csv":
                case "mht":
                case "ods":
                case "prn":
                case "slk":
                    ConvertExcelToPdf(name, ext, parameters.Count, parameters.Threads);
                    break;
                case "ppt":
                case "pptx":
                case "pptm":
                case "pps":
                case "ppsm":
                case "ppsx":
                case "odp":
                    ConvertPowerPointToPdf(name, ext, parameters.Count, parameters.Threads);
                    break;
            }
            return "Convert Success!";
        }

        void ConvertWordToPdf(string name = "file", string ext = "docx", int count = 1, int threads = 1)
        {
            var total = count;
            var offset = total / threads;
            var parametersDocx = new WordViewPdfParams
            {
                Offset = 0,
                Count = offset,
                Config = _config,
                SourceFileName = name,
                SourceFileType = ext,
                ResultFileName = name,
                ResultFileType = ".pdf"
            };

            for (int i = 0; i < threads; i++)
            {
                parametersDocx.Offset = i * offset;
                var uploadDocx = new WordToPdfThread("THREAD " + i + ", View PDF of " + offset + " DOCX", parametersDocx);
            }
        }

        void ConvertExcelToPdf(string name = "file", string ext = "xlsx", int count = 1, int threads = 1)
        {
            var total = count;
            var offset = total / threads;

            var parametersXlsx = new ExcelViewPdfParams
            {
                Offset = 0,
                Count = offset,
                Config = _config,
                SourceFileName = name,
                SourceFileType = ext,
                ResultFileName = name,
                ResultFileType = ".pdf"
            };

            for (int i = 0; i < threads; i++)
            {
                parametersXlsx.Offset = i * offset;
                var uploadXlsx = new ExcelToPdfThread("THREAD " + i + ", View PDF of " + offset + " XLSX", parametersXlsx);
            }
        }

        void ConvertPowerPointToPdf(string name = "file", string ext = "pptx", int count = 1, int threads = 1)
        {
            var total = count;
            var offset = total / threads;

            var parametersPptx = new PptViewPdfParams
            {
                Offset = 0,
                Count = offset,
                Config = _config,
                SourceFileName = name,
                SourceFileType = ext,
                ResultFileName = name,
                ResultFileType = ".pdf"
            };

            for (int i = 0; i < threads; i++)
            {
                parametersPptx.Offset = i * offset;
                var uploadPptx = new PptToPdfThread("THREAD " + i + ", View PDF of " + offset + " PPTX", parametersPptx);
            }
        }

        void InitConsole()
        {
            Console.WriteLine("This text you can see in debug output window.");

            AllocConsole();
            IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
            SafeFileHandle safeFileHandle = new SafeFileHandle(stdHandle, true);
            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
            Encoding encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE);
            StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
        }


    }
}