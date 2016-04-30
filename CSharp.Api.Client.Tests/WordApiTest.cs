using System;
using System.Collections.Generic;
using System.Linq;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO.Swagger.Model;
using System.Net;
using System.IO;

namespace CSharp.Api.Client.Tests
{
    [TestClass]
    public class WordApiTest
    {
        [TestMethod]
        public void WordConvertTestPDF()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            word.WordConvert("letterlegal5.doc", "letterlegal5.pdf", "pdf");

            var file = new FileApi(config);
            var result = file.FileList();

            Assert.IsTrue(result.Contains("letterlegal5.pdf"));
        }

        [TestMethod]
        public void WordConvertToPDFTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            var result = word.WordConvertToPDF("letterlegal5.doc", "letterlegal5.pdf");

            Assert.IsTrue(result.Contains("letterlegal5"));
        }

        [TestMethod]
        public void WordPageCountTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            var result = word.WordPageCount("letterlegal5.doc");

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void WordWordCountTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            var result = word.WordWordCount("letterlegal5.doc");

            Assert.AreEqual(518, result);
        }

        [TestMethod]
        public void WordPageWordCountTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            var result = word.WordPageWordCount("letterlegal5.doc", 1);

            Assert.AreEqual(94, result);
        }

        [TestMethod]
        public void WordParagraphCountTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            var result = word.WordParagraphCount("letterlegal5.doc");

            Assert.AreEqual(278, result);
        }

        [TestMethod]
        public void WordPageParagraphCountTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            var result = word.WordPageParagraphCount("letterlegal5.doc", 1);

            Assert.AreEqual(46, result);
        }

        [TestMethod]
        public void WordSplitTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            word.WordSplit("letterlegal5.doc", "letterlegal5_split.doc", 1, 2);

            var file = new FileApi(config);
            var result = file.FileList();

            Assert.IsTrue(result.Contains("letterlegal5_split.doc"));
        }

        [TestMethod]
        public void WordJoinTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            word.WordJoin("letterlegal5.doc", "letterlegal5_join.doc", "letterlegal52.doc");

            var file = new FileApi(config);
            var result = file.FileList();

            Assert.IsTrue(result.Contains("letterlegal5_join.doc"));
        }

        [TestMethod]
        public void WordFindAndReplaceTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            word.WordFindAndReplace("letterlegal5.doc", "letterlegal5_replace.doc", new List<string> { "1" }, new List<string> { "!" });

            var file = new FileApi(config);
            var result = file.FileList();

            Assert.IsTrue(result.Contains("letterlegal5_replace.doc"));
        }

        [TestMethod]
        public void WordFindAndReplaceTestMultiply()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            word.WordFindAndReplace("letterlegal5.doc", "letterlegal5_replace2.doc", new List<string> { "1", "2" }, new List<string> { "!", "!" });

            var file = new FileApi(config);
            var result = file.FileList();

            Assert.IsTrue(result.Contains("letterlegal5_replace2.doc"));
        }

        [TestMethod]
        public void WordTextWatermarkTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            word.WordTextWatermark("letterlegal5.doc", "letterlegal5_watermark.doc", "Hello World");

            var file = new FileApi(config);
            var result = file.FileList();

            Assert.IsTrue(result.Contains("letterlegal5_watermark.doc"));
        }

        [TestMethod]
        public void WordImageWatermarkPostTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var stream = File.Open("D://Temp/temp.png", FileMode.Open);

            var word = new WordApi(config);
            word.WordImageWatermarkPost("letterlegal5.doc", "letterlegal5_image_watermark.doc", stream);

            var file = new FileApi(config);
            var result = file.FileList();

            Assert.IsTrue(result.Contains("letterlegal5_image_watermark.doc"));
        }

        [TestMethod]
        public void WordGetDocumentPropertiesTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            var result = word.WordGetDocumentProperties("letterlegal5.doc");

            Assert.AreEqual("Sample document created with MS Word", result["Title"]);
        }

        [TestMethod]
        public void WordSetDocumentPropertiesTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            var prop = new Properties();
            prop.Add("Title", "Set Metadata Test");
            word.WordSetDocumentProperties("letterlegal5.doc", "letterlegal5_metadata.doc", prop);

            var result = word.WordGetDocumentProperties("letterlegal5_metadata.doc");

            Assert.AreEqual("Set Metadata Test", result["Title"]);
        }

        [TestMethod]
        public void WordThumbnailTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            var result = word.WordThumbnail("letterlegal5.doc");

            Assert.IsTrue(result.Contains("letterlegal50.png"));
        }

        [TestMethod]
        public void WordThumbnailTestRange()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            var result = word.WordThumbnail("letterlegal5.doc", startPageNumber: 1, endPageNumber: 2);

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void WordMailMergeTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var word = new WordApi(config);
            word.WordMailMerge("template1.docx", "mailmerge.docx", "source3.txt");

            var file = new FileApi(config);
            var result = file.FileList();

            Assert.IsTrue(result.Contains("source3.txt"));
        }
    }
}
