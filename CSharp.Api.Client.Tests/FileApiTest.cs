using System;
using System.Collections.Generic;
using System.Linq;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace TestSaasApiClient
{
    [TestClass]
    public class FileApiTest
    {
        [TestMethod]
        public void FileListTestBasicAuth()
        {
            var config = new Configuration(username: "Test12", password: "Test12");
            config.ApiClient = new ApiClient(config);
            var client = new FileApi(config);

            var result = client.FileList();

            Assert.IsTrue(result.Any());
        }

        [TestMethod]
        public void FileUploadTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var file = new FileApi(config);
            file.FileUploadPost("letterlegal5.doc", File.Open("D://Temp/letterlegal5.doc", FileMode.Open));

            var result = file.FileList();

            Assert.IsTrue(result.Contains("letterlegal5.doc"));
        }

        [TestMethod]
        public void FileDownloadToStreamTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var file = new FileApi(config);
            var stream = file.FileDownloadToStream("letterlegal5.doc");

            Assert.IsTrue(stream is FileStream);
        }
    }
}
