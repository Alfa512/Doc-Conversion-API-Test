using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExcelApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="fitToPage"></param>
        /// <param name="landscape"></param>
        /// <returns>string</returns>
        string ExcelConvertToPDF (string sourceFileName, string resultFileName = null, bool? fitToPage = null, bool? landscape = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="fitToPage"></param>
        /// <param name="landscape"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ExcelConvertToPDFWithHttpInfo (string sourceFileName, string resultFileName = null, bool? fitToPage = null, bool? landscape = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="fitToPage"></param>
        /// <param name="landscape"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ExcelConvertToPDFAsync (string sourceFileName, string resultFileName = null, bool? fitToPage = null, bool? landscape = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="fitToPage"></param>
        /// <param name="landscape"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ExcelConvertToPDFAsyncWithHttpInfo (string sourceFileName, string resultFileName = null, bool? fitToPage = null, bool? landscape = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ExcelApi : IExcelApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExcelApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExcelApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="fitToPage"></param> 
        /// <param name="landscape"></param> 
        /// <returns>string</returns>
        public string ExcelConvertToPDF (string sourceFileName, string resultFileName = null, bool? fitToPage = null, bool? landscape = null)
        {
             ApiResponse<string> response = ExcelConvertToPDFWithHttpInfo(sourceFileName, resultFileName, fitToPage, landscape);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="fitToPage"></param> 
        /// <param name="landscape"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ExcelConvertToPDFWithHttpInfo (string sourceFileName, string resultFileName = null, bool? fitToPage = null, bool? landscape = null)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling ExcelApi->ExcelConvertToPDF");
            
    
            var path_ = "/api/excel/pdfviewer";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (fitToPage != null) queryParams.Add("FitToPage", Configuration.ApiClient.ParameterToString(fitToPage)); // query parameter
            if (landscape != null) queryParams.Add("Landscape", Configuration.ApiClient.ParameterToString(landscape)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ExcelConvertToPDF: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ExcelConvertToPDF: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="fitToPage"></param>
        /// <param name="landscape"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ExcelConvertToPDFAsync (string sourceFileName, string resultFileName = null, bool? fitToPage = null, bool? landscape = null)
        {
             ApiResponse<string> response = await ExcelConvertToPDFAsyncWithHttpInfo(sourceFileName, resultFileName, fitToPage, landscape);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="fitToPage"></param>
        /// <param name="landscape"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ExcelConvertToPDFAsyncWithHttpInfo (string sourceFileName, string resultFileName = null, bool? fitToPage = null, bool? landscape = null)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling ExcelConvertToPDF");
            
    
            var path_ = "/api/excel/pdfviewer";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (fitToPage != null) queryParams.Add("FitToPage", Configuration.ApiClient.ParameterToString(fitToPage)); // query parameter
            if (landscape != null) queryParams.Add("Landscape", Configuration.ApiClient.ParameterToString(landscape)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ExcelConvertToPDF: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ExcelConvertToPDF: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
