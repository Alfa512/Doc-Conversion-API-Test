using System;
using System.Collections.Generic;
using System.Linq;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSaasApiClient
{
    [TestClass]
    public class ServiceApiTest
    {
        [TestMethod]
        public void ServiceStatusTestBasicAuth()
        {
            var config = new Configuration(username: "Test12", password: "Test12");
            config.ApiClient = new ApiClient(config);

            var client = new ServiceApi(config);
            var result = client.ServiceStatus();

            Assert.AreEqual("\"Doc Conversion API is online.\"", result);
        }

        [TestMethod]
        public void ServiceStatusTestApiKeyAuth()
        {
            var apiKey = new Dictionary<string, string>() 
            { 
                { "AppSecret", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" }, 
                { "AppId", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" } 
            };

            var config = new Configuration(apiKey: apiKey);
            config.ApiClient = new ApiClient(config);

            var client = new ServiceApi(config);
            var result = client.ServiceStatus();

            Assert.AreEqual("\"Doc Conversion API is online.\"", result);
        }
    }
}
