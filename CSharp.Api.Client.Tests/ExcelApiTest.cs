using System;
using System.Collections.Generic;
using System.Linq;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Api.Client.Tests
{
    [TestClass]
    public class ExcelApiTest
    {
        [TestMethod]
        public void ExcelConvertToPDFTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var excel = new ExcelApi(config);
            var result = excel.ExcelConvertToPDF("excel_sample.xlsx", "excel_sample.pdf");

            Assert.IsTrue(result.Contains("excel_sample"));
        }
    }
}
