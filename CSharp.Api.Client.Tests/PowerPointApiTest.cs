using System;
using System.Collections.Generic;
using System.Linq;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Api.Client.Tests
{
    [TestClass]
    public class PowerPointApiTest
    {
        [TestMethod, Ignore]
        public void PowerPointConvertToPDFTest()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var pp = new PowerPointApi(config);
            var result = pp.PowerPointConvertToPDF("ppt_sample.ppt", "ppt_sample.pdf");

            Assert.IsTrue(result.Contains("ppt_sample"));
        
        }
    }
}
