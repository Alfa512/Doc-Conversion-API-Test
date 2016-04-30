using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServiceApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;UserApp&gt;</returns>
        List<UserApp> ServiceApplications ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;UserApp&gt;</returns>
        ApiResponse<List<UserApp>> ServiceApplicationsWithHttpInfo ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;UserApp&gt;</returns>
        System.Threading.Tasks.Task<List<UserApp>> ServiceApplicationsAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;UserApp&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UserApp>>> ServiceApplicationsAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>List&lt;ActionLog&gt;</returns>
        List<ActionLog> ServiceCalls (int? year, int? month, string appId = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>ApiResponse of List&lt;ActionLog&gt;</returns>
        ApiResponse<List<ActionLog>> ServiceCallsWithHttpInfo (int? year, int? month, string appId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>Task of List&lt;ActionLog&gt;</returns>
        System.Threading.Tasks.Task<List<ActionLog>> ServiceCallsAsync (int? year, int? month, string appId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>Task of ApiResponse (List&lt;ActionLog&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ActionLog>>> ServiceCallsAsyncWithHttpInfo (int? year, int? month, string appId = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>UserApp</returns>
        UserApp ServiceCreateApplications (string name);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>ApiResponse of UserApp</returns>
        ApiResponse<UserApp> ServiceCreateApplicationsWithHttpInfo (string name);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>Task of UserApp</returns>
        System.Threading.Tasks.Task<UserApp> ServiceCreateApplicationsAsync (string name);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse (UserApp)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserApp>> ServiceCreateApplicationsAsyncWithHttpInfo (string name);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="appId"></param>
        /// <returns>UserApp</returns>
        UserApp ServiceCreateNewSecretKey (string appId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="appId"></param>
        /// <returns>ApiResponse of UserApp</returns>
        ApiResponse<UserApp> ServiceCreateNewSecretKeyWithHttpInfo (string appId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="appId"></param>
        /// <returns>Task of UserApp</returns>
        System.Threading.Tasks.Task<UserApp> ServiceCreateNewSecretKeyAsync (string appId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="appId"></param>
        /// <returns>Task of ApiResponse (UserApp)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserApp>> ServiceCreateNewSecretKeyAsyncWithHttpInfo (string appId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;ApiMethod&gt;</returns>
        List<ApiMethod> ServiceDashboardData ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;ApiMethod&gt;</returns>
        ApiResponse<List<ApiMethod>> ServiceDashboardDataWithHttpInfo ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;ApiMethod&gt;</returns>
        System.Threading.Tasks.Task<List<ApiMethod>> ServiceDashboardDataAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;ApiMethod&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ApiMethod>>> ServiceDashboardDataAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Result</returns>
        Result ServiceDeleteApplications (string id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Result</returns>
        ApiResponse<Result> ServiceDeleteApplicationsWithHttpInfo (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Task of Result</returns>
        System.Threading.Tasks.Task<Result> ServiceDeleteApplicationsAsync (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result>> ServiceDeleteApplicationsAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>List&lt;ExceptionLog&gt;</returns>
        List<ExceptionLog> ServiceErrors (int? year, int? month, string appId = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>ApiResponse of List&lt;ExceptionLog&gt;</returns>
        ApiResponse<List<ExceptionLog>> ServiceErrorsWithHttpInfo (int? year, int? month, string appId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>Task of List&lt;ExceptionLog&gt;</returns>
        System.Threading.Tasks.Task<List<ExceptionLog>> ServiceErrorsAsync (int? year, int? month, string appId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>Task of ApiResponse (List&lt;ExceptionLog&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ExceptionLog>>> ServiceErrorsAsyncWithHttpInfo (int? year, int? month, string appId = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;ApiMethod&gt;</returns>
        List<ApiMethod> ServiceUsageMethodList ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;ApiMethod&gt;</returns>
        ApiResponse<List<ApiMethod>> ServiceUsageMethodListWithHttpInfo ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;ApiMethod&gt;</returns>
        System.Threading.Tasks.Task<List<ApiMethod>> ServiceUsageMethodListAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;ApiMethod&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ApiMethod>>> ServiceUsageMethodListAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Result</returns>
        Result ServiceSetDefaultApplications (string id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Result</returns>
        ApiResponse<Result> ServiceSetDefaultApplicationsWithHttpInfo (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Task of Result</returns>
        System.Threading.Tasks.Task<Result> ServiceSetDefaultApplicationsAsync (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result>> ServiceSetDefaultApplicationsAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>string</returns>
        string ServiceStatus ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ServiceStatusWithHttpInfo ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ServiceStatusAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ServiceStatusAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="appId"></param>
        /// <param name="name"></param>
        /// <returns>UserApp</returns>
        UserApp ServiceUpdateAppName (string appId, string name);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="appId"></param>
        /// <param name="name"></param>
        /// <returns>ApiResponse of UserApp</returns>
        ApiResponse<UserApp> ServiceUpdateAppNameWithHttpInfo (string appId, string name);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="appId"></param>
        /// <param name="name"></param>
        /// <returns>Task of UserApp</returns>
        System.Threading.Tasks.Task<UserApp> ServiceUpdateAppNameAsync (string appId, string name);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="appId"></param>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse (UserApp)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserApp>> ServiceUpdateAppNameAsyncWithHttpInfo (string appId, string name);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <param name="method"></param>
        /// <returns>List&lt;ActionLog&gt;</returns>
        List<ActionLog> ServiceUsage (int? year, int? month, string appId = null, string method = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <param name="method"></param>
        /// <returns>ApiResponse of List&lt;ActionLog&gt;</returns>
        ApiResponse<List<ActionLog>> ServiceUsageWithHttpInfo (int? year, int? month, string appId = null, string method = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <param name="method"></param>
        /// <returns>Task of List&lt;ActionLog&gt;</returns>
        System.Threading.Tasks.Task<List<ActionLog>> ServiceUsageAsync (int? year, int? month, string appId = null, string method = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <param name="method"></param>
        /// <returns>Task of ApiResponse (List&lt;ActionLog&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ActionLog>>> ServiceUsageAsyncWithHttpInfo (int? year, int? month, string appId = null, string method = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ServiceApi : IServiceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServiceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServiceApi(Configuration configuration = null)
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
        /// <returns>List&lt;UserApp&gt;</returns>
        public List<UserApp> ServiceApplications ()
        {
             ApiResponse<List<UserApp>> response = ServiceApplicationsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>ApiResponse of List&lt;UserApp&gt;</returns>
        public ApiResponse< List<UserApp> > ServiceApplicationsWithHttpInfo ()
        {
            
    
            var path_ = "/api/service/applications";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceApplications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceApplications: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<UserApp>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserApp>) Configuration.ApiClient.Deserialize(response, typeof(List<UserApp>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of List&lt;UserApp&gt;</returns>
        public async System.Threading.Tasks.Task<List<UserApp>> ServiceApplicationsAsync ()
        {
             ApiResponse<List<UserApp>> response = await ServiceApplicationsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;UserApp&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UserApp>>> ServiceApplicationsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/service/applications";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceApplications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceApplications: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<UserApp>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserApp>) Configuration.ApiClient.Deserialize(response, typeof(List<UserApp>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param> 
        /// <param name="month"></param> 
        /// <param name="appId"></param> 
        /// <returns>List&lt;ActionLog&gt;</returns>
        public List<ActionLog> ServiceCalls (int? year, int? month, string appId = null)
        {
             ApiResponse<List<ActionLog>> response = ServiceCallsWithHttpInfo(year, month, appId);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param> 
        /// <param name="month"></param> 
        /// <param name="appId"></param> 
        /// <returns>ApiResponse of List&lt;ActionLog&gt;</returns>
        public ApiResponse< List<ActionLog> > ServiceCallsWithHttpInfo (int? year, int? month, string appId = null)
        {
            
            // verify the required parameter 'year' is set
            if (year == null)
                throw new ApiException(400, "Missing required parameter 'year' when calling ServiceApi->ServiceCalls");
            
            // verify the required parameter 'month' is set
            if (month == null)
                throw new ApiException(400, "Missing required parameter 'month' when calling ServiceApi->ServiceCalls");
            
    
            var path_ = "/api/service/calls";
    
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
            
            if (year != null) queryParams.Add("year", Configuration.ApiClient.ParameterToString(year)); // query parameter
            if (month != null) queryParams.Add("month", Configuration.ApiClient.ParameterToString(month)); // query parameter
            if (appId != null) queryParams.Add("appId", Configuration.ApiClient.ParameterToString(appId)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceCalls: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceCalls: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<ActionLog>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ActionLog>) Configuration.ApiClient.Deserialize(response, typeof(List<ActionLog>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>Task of List&lt;ActionLog&gt;</returns>
        public async System.Threading.Tasks.Task<List<ActionLog>> ServiceCallsAsync (int? year, int? month, string appId = null)
        {
             ApiResponse<List<ActionLog>> response = await ServiceCallsAsyncWithHttpInfo(year, month, appId);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>Task of ApiResponse (List&lt;ActionLog&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ActionLog>>> ServiceCallsAsyncWithHttpInfo (int? year, int? month, string appId = null)
        {
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling ServiceCalls");
            // verify the required parameter 'month' is set
            if (month == null) throw new ApiException(400, "Missing required parameter 'month' when calling ServiceCalls");
            
    
            var path_ = "/api/service/calls";
    
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
            
            if (year != null) queryParams.Add("year", Configuration.ApiClient.ParameterToString(year)); // query parameter
            if (month != null) queryParams.Add("month", Configuration.ApiClient.ParameterToString(month)); // query parameter
            if (appId != null) queryParams.Add("appId", Configuration.ApiClient.ParameterToString(appId)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceCalls: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceCalls: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<ActionLog>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ActionLog>) Configuration.ApiClient.Deserialize(response, typeof(List<ActionLog>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <returns>UserApp</returns>
        public UserApp ServiceCreateApplications (string name)
        {
             ApiResponse<UserApp> response = ServiceCreateApplicationsWithHttpInfo(name);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <returns>ApiResponse of UserApp</returns>
        public ApiResponse< UserApp > ServiceCreateApplicationsWithHttpInfo (string name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ServiceApi->ServiceCreateApplications");
            
    
            var path_ = "/api/service/createapplications";
    
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
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceCreateApplications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceCreateApplications: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserApp>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserApp) Configuration.ApiClient.Deserialize(response, typeof(UserApp)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Task of UserApp</returns>
        public async System.Threading.Tasks.Task<UserApp> ServiceCreateApplicationsAsync (string name)
        {
             ApiResponse<UserApp> response = await ServiceCreateApplicationsAsyncWithHttpInfo(name);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse (UserApp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserApp>> ServiceCreateApplicationsAsyncWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ServiceCreateApplications");
            
    
            var path_ = "/api/service/createapplications";
    
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
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceCreateApplications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceCreateApplications: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserApp>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserApp) Configuration.ApiClient.Deserialize(response, typeof(UserApp)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="appId"></param> 
        /// <returns>UserApp</returns>
        public UserApp ServiceCreateNewSecretKey (string appId)
        {
             ApiResponse<UserApp> response = ServiceCreateNewSecretKeyWithHttpInfo(appId);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="appId"></param> 
        /// <returns>ApiResponse of UserApp</returns>
        public ApiResponse< UserApp > ServiceCreateNewSecretKeyWithHttpInfo (string appId)
        {
            
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling ServiceApi->ServiceCreateNewSecretKey");
            
    
            var path_ = "/api/service/createnewsecretkey";
    
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
            
            if (appId != null) queryParams.Add("appId", Configuration.ApiClient.ParameterToString(appId)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceCreateNewSecretKey: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceCreateNewSecretKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserApp>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserApp) Configuration.ApiClient.Deserialize(response, typeof(UserApp)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="appId"></param>
        /// <returns>Task of UserApp</returns>
        public async System.Threading.Tasks.Task<UserApp> ServiceCreateNewSecretKeyAsync (string appId)
        {
             ApiResponse<UserApp> response = await ServiceCreateNewSecretKeyAsyncWithHttpInfo(appId);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="appId"></param>
        /// <returns>Task of ApiResponse (UserApp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserApp>> ServiceCreateNewSecretKeyAsyncWithHttpInfo (string appId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null) throw new ApiException(400, "Missing required parameter 'appId' when calling ServiceCreateNewSecretKey");
            
    
            var path_ = "/api/service/createnewsecretkey";
    
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
            
            if (appId != null) queryParams.Add("appId", Configuration.ApiClient.ParameterToString(appId)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceCreateNewSecretKey: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceCreateNewSecretKey: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserApp>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserApp) Configuration.ApiClient.Deserialize(response, typeof(UserApp)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <returns>List&lt;ApiMethod&gt;</returns>
        public List<ApiMethod> ServiceDashboardData ()
        {
             ApiResponse<List<ApiMethod>> response = ServiceDashboardDataWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>ApiResponse of List&lt;ApiMethod&gt;</returns>
        public ApiResponse< List<ApiMethod> > ServiceDashboardDataWithHttpInfo ()
        {
            
    
            var path_ = "/api/service/dashboarddata";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceDashboardData: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceDashboardData: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<ApiMethod>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ApiMethod>) Configuration.ApiClient.Deserialize(response, typeof(List<ApiMethod>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of List&lt;ApiMethod&gt;</returns>
        public async System.Threading.Tasks.Task<List<ApiMethod>> ServiceDashboardDataAsync ()
        {
             ApiResponse<List<ApiMethod>> response = await ServiceDashboardDataAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;ApiMethod&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ApiMethod>>> ServiceDashboardDataAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/service/dashboarddata";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceDashboardData: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceDashboardData: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<ApiMethod>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ApiMethod>) Configuration.ApiClient.Deserialize(response, typeof(List<ApiMethod>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>Result</returns>
        public Result ServiceDeleteApplications (string id)
        {
             ApiResponse<Result> response = ServiceDeleteApplicationsWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>ApiResponse of Result</returns>
        public ApiResponse< Result > ServiceDeleteApplicationsWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceApi->ServiceDeleteApplications");
            
    
            var path_ = "/api/service/deleteapplications";
    
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
                "application/json", "text/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceDeleteApplications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceDeleteApplications: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task of Result</returns>
        public async System.Threading.Tasks.Task<Result> ServiceDeleteApplicationsAsync (string id)
        {
             ApiResponse<Result> response = await ServiceDeleteApplicationsAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Result>> ServiceDeleteApplicationsAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ServiceDeleteApplications");
            
    
            var path_ = "/api/service/deleteapplications";
    
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
                "application/json", "text/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceDeleteApplications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceDeleteApplications: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param> 
        /// <param name="month"></param> 
        /// <param name="appId"></param> 
        /// <returns>List&lt;ExceptionLog&gt;</returns>
        public List<ExceptionLog> ServiceErrors (int? year, int? month, string appId = null)
        {
             ApiResponse<List<ExceptionLog>> response = ServiceErrorsWithHttpInfo(year, month, appId);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param> 
        /// <param name="month"></param> 
        /// <param name="appId"></param> 
        /// <returns>ApiResponse of List&lt;ExceptionLog&gt;</returns>
        public ApiResponse< List<ExceptionLog> > ServiceErrorsWithHttpInfo (int? year, int? month, string appId = null)
        {
            
            // verify the required parameter 'year' is set
            if (year == null)
                throw new ApiException(400, "Missing required parameter 'year' when calling ServiceApi->ServiceErrors");
            
            // verify the required parameter 'month' is set
            if (month == null)
                throw new ApiException(400, "Missing required parameter 'month' when calling ServiceApi->ServiceErrors");
            
    
            var path_ = "/api/service/errors";
    
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
            
            if (year != null) queryParams.Add("year", Configuration.ApiClient.ParameterToString(year)); // query parameter
            if (month != null) queryParams.Add("month", Configuration.ApiClient.ParameterToString(month)); // query parameter
            if (appId != null) queryParams.Add("appId", Configuration.ApiClient.ParameterToString(appId)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceErrors: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceErrors: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<ExceptionLog>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ExceptionLog>) Configuration.ApiClient.Deserialize(response, typeof(List<ExceptionLog>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>Task of List&lt;ExceptionLog&gt;</returns>
        public async System.Threading.Tasks.Task<List<ExceptionLog>> ServiceErrorsAsync (int? year, int? month, string appId = null)
        {
             ApiResponse<List<ExceptionLog>> response = await ServiceErrorsAsyncWithHttpInfo(year, month, appId);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <returns>Task of ApiResponse (List&lt;ExceptionLog&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ExceptionLog>>> ServiceErrorsAsyncWithHttpInfo (int? year, int? month, string appId = null)
        {
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling ServiceErrors");
            // verify the required parameter 'month' is set
            if (month == null) throw new ApiException(400, "Missing required parameter 'month' when calling ServiceErrors");
            
    
            var path_ = "/api/service/errors";
    
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
            
            if (year != null) queryParams.Add("year", Configuration.ApiClient.ParameterToString(year)); // query parameter
            if (month != null) queryParams.Add("month", Configuration.ApiClient.ParameterToString(month)); // query parameter
            if (appId != null) queryParams.Add("appId", Configuration.ApiClient.ParameterToString(appId)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceErrors: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceErrors: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<ExceptionLog>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ExceptionLog>) Configuration.ApiClient.Deserialize(response, typeof(List<ExceptionLog>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <returns>List&lt;ApiMethod&gt;</returns>
        public List<ApiMethod> ServiceUsageMethodList ()
        {
             ApiResponse<List<ApiMethod>> response = ServiceUsageMethodListWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>ApiResponse of List&lt;ApiMethod&gt;</returns>
        public ApiResponse< List<ApiMethod> > ServiceUsageMethodListWithHttpInfo ()
        {
            
    
            var path_ = "/api/service/methodlist";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceUsageMethodList: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceUsageMethodList: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<ApiMethod>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ApiMethod>) Configuration.ApiClient.Deserialize(response, typeof(List<ApiMethod>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of List&lt;ApiMethod&gt;</returns>
        public async System.Threading.Tasks.Task<List<ApiMethod>> ServiceUsageMethodListAsync ()
        {
             ApiResponse<List<ApiMethod>> response = await ServiceUsageMethodListAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;ApiMethod&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ApiMethod>>> ServiceUsageMethodListAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/service/methodlist";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceUsageMethodList: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceUsageMethodList: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<ApiMethod>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ApiMethod>) Configuration.ApiClient.Deserialize(response, typeof(List<ApiMethod>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>Result</returns>
        public Result ServiceSetDefaultApplications (string id)
        {
             ApiResponse<Result> response = ServiceSetDefaultApplicationsWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>ApiResponse of Result</returns>
        public ApiResponse< Result > ServiceSetDefaultApplicationsWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceApi->ServiceSetDefaultApplications");
            
    
            var path_ = "/api/service/setdefault";
    
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
                "application/json", "text/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceSetDefaultApplications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceSetDefaultApplications: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task of Result</returns>
        public async System.Threading.Tasks.Task<Result> ServiceSetDefaultApplicationsAsync (string id)
        {
             ApiResponse<Result> response = await ServiceSetDefaultApplicationsAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Result>> ServiceSetDefaultApplicationsAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ServiceSetDefaultApplications");
            
    
            var path_ = "/api/service/setdefault";
    
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
                "application/json", "text/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceSetDefaultApplications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceSetDefaultApplications: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <returns>string</returns>
        public string ServiceStatus ()
        {
             ApiResponse<string> response = ServiceStatusWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ServiceStatusWithHttpInfo ()
        {
            
    
            var path_ = "/api/service/status";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceStatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ServiceStatusAsync ()
        {
             ApiResponse<string> response = await ServiceStatusAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ServiceStatusAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/service/status";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceStatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceStatus: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="appId"></param> 
        /// <param name="name"></param> 
        /// <returns>UserApp</returns>
        public UserApp ServiceUpdateAppName (string appId, string name)
        {
             ApiResponse<UserApp> response = ServiceUpdateAppNameWithHttpInfo(appId, name);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="appId"></param> 
        /// <param name="name"></param> 
        /// <returns>ApiResponse of UserApp</returns>
        public ApiResponse< UserApp > ServiceUpdateAppNameWithHttpInfo (string appId, string name)
        {
            
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling ServiceApi->ServiceUpdateAppName");
            
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ServiceApi->ServiceUpdateAppName");
            
    
            var path_ = "/api/service/updateappname";
    
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
            
            if (appId != null) queryParams.Add("appId", Configuration.ApiClient.ParameterToString(appId)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceUpdateAppName: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceUpdateAppName: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserApp>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserApp) Configuration.ApiClient.Deserialize(response, typeof(UserApp)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="name"></param>
        /// <returns>Task of UserApp</returns>
        public async System.Threading.Tasks.Task<UserApp> ServiceUpdateAppNameAsync (string appId, string name)
        {
             ApiResponse<UserApp> response = await ServiceUpdateAppNameAsyncWithHttpInfo(appId, name);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse (UserApp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserApp>> ServiceUpdateAppNameAsyncWithHttpInfo (string appId, string name)
        {
            // verify the required parameter 'appId' is set
            if (appId == null) throw new ApiException(400, "Missing required parameter 'appId' when calling ServiceUpdateAppName");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ServiceUpdateAppName");
            
    
            var path_ = "/api/service/updateappname";
    
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
            
            if (appId != null) queryParams.Add("appId", Configuration.ApiClient.ParameterToString(appId)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceUpdateAppName: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceUpdateAppName: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserApp>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserApp) Configuration.ApiClient.Deserialize(response, typeof(UserApp)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param> 
        /// <param name="month"></param> 
        /// <param name="appId"></param> 
        /// <param name="method"></param> 
        /// <returns>List&lt;ActionLog&gt;</returns>
        public List<ActionLog> ServiceUsage (int? year, int? month, string appId = null, string method = null)
        {
             ApiResponse<List<ActionLog>> response = ServiceUsageWithHttpInfo(year, month, appId, method);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param> 
        /// <param name="month"></param> 
        /// <param name="appId"></param> 
        /// <param name="method"></param> 
        /// <returns>ApiResponse of List&lt;ActionLog&gt;</returns>
        public ApiResponse< List<ActionLog> > ServiceUsageWithHttpInfo (int? year, int? month, string appId = null, string method = null)
        {
            
            // verify the required parameter 'year' is set
            if (year == null)
                throw new ApiException(400, "Missing required parameter 'year' when calling ServiceApi->ServiceUsage");
            
            // verify the required parameter 'month' is set
            if (month == null)
                throw new ApiException(400, "Missing required parameter 'month' when calling ServiceApi->ServiceUsage");
            
    
            var path_ = "/api/service/usage";
    
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
            
            if (year != null) queryParams.Add("year", Configuration.ApiClient.ParameterToString(year)); // query parameter
            if (month != null) queryParams.Add("month", Configuration.ApiClient.ParameterToString(month)); // query parameter
            if (appId != null) queryParams.Add("appId", Configuration.ApiClient.ParameterToString(appId)); // query parameter
            if (method != null) queryParams.Add("method", Configuration.ApiClient.ParameterToString(method)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceUsage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceUsage: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<ActionLog>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ActionLog>) Configuration.ApiClient.Deserialize(response, typeof(List<ActionLog>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <param name="method"></param>
        /// <returns>Task of List&lt;ActionLog&gt;</returns>
        public async System.Threading.Tasks.Task<List<ActionLog>> ServiceUsageAsync (int? year, int? month, string appId = null, string method = null)
        {
             ApiResponse<List<ActionLog>> response = await ServiceUsageAsyncWithHttpInfo(year, month, appId, method);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="appId"></param>
        /// <param name="method"></param>
        /// <returns>Task of ApiResponse (List&lt;ActionLog&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ActionLog>>> ServiceUsageAsyncWithHttpInfo (int? year, int? month, string appId = null, string method = null)
        {
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling ServiceUsage");
            // verify the required parameter 'month' is set
            if (month == null) throw new ApiException(400, "Missing required parameter 'month' when calling ServiceUsage");
            
    
            var path_ = "/api/service/usage";
    
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
            
            if (year != null) queryParams.Add("year", Configuration.ApiClient.ParameterToString(year)); // query parameter
            if (month != null) queryParams.Add("month", Configuration.ApiClient.ParameterToString(month)); // query parameter
            if (appId != null) queryParams.Add("appId", Configuration.ApiClient.ParameterToString(appId)); // query parameter
            if (method != null) queryParams.Add("method", Configuration.ApiClient.ParameterToString(method)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ServiceUsage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ServiceUsage: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<ActionLog>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ActionLog>) Configuration.ApiClient.Deserialize(response, typeof(List<ActionLog>)));
            
        }
        
    }
    
}
