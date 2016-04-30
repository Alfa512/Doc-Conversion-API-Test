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
    public interface IUserApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="oldpassword"></param>
        /// <param name="password"></param>
        /// <returns>Result</returns>
        Result UserChangePassword (string oldpassword, string password);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="oldpassword"></param>
        /// <param name="password"></param>
        /// <returns>ApiResponse of Result</returns>
        ApiResponse<Result> UserChangePasswordWithHttpInfo (string oldpassword, string password);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="oldpassword"></param>
        /// <param name="password"></param>
        /// <returns>Task of Result</returns>
        System.Threading.Tasks.Task<Result> UserChangePasswordAsync (string oldpassword, string password);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="oldpassword"></param>
        /// <param name="password"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result>> UserChangePasswordAsyncWithHttpInfo (string oldpassword, string password);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token"></param>
        /// <returns>ResultBool</returns>
        ResultBool UserCheckToken (string token);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token"></param>
        /// <returns>ApiResponse of ResultBool</returns>
        ApiResponse<ResultBool> UserCheckTokenWithHttpInfo (string token);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token"></param>
        /// <returns>Task of ResultBool</returns>
        System.Threading.Tasks.Task<ResultBool> UserCheckTokenAsync (string token);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token"></param>
        /// <returns>Task of ApiResponse (ResultBool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResultBool>> UserCheckTokenAsyncWithHttpInfo (string token);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns>Result</returns>
        Result UserCreate (string name, string password, string email);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns>ApiResponse of Result</returns>
        ApiResponse<Result> UserCreateWithHttpInfo (string name, string password, string email);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns>Task of Result</returns>
        System.Threading.Tasks.Task<Result> UserCreateAsync (string name, string password, string email);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result>> UserCreateAsyncWithHttpInfo (string name, string password, string email);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Result</returns>
        Result UserCurrentUser ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Result</returns>
        ApiResponse<Result> UserCurrentUserWithHttpInfo ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of Result</returns>
        System.Threading.Tasks.Task<Result> UserCurrentUserAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (Result)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result>> UserCurrentUserAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ResultBool</returns>
        ResultBool UserIsDefaultUserEnabled ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of ResultBool</returns>
        ApiResponse<ResultBool> UserIsDefaultUserEnabledWithHttpInfo ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ResultBool</returns>
        System.Threading.Tasks.Task<ResultBool> UserIsDefaultUserEnabledAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (ResultBool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResultBool>> UserIsDefaultUserEnabledAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>ResultString</returns>
        ResultString UserLogin (string name, string password);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>ApiResponse of ResultString</returns>
        ApiResponse<ResultString> UserLoginWithHttpInfo (string name, string password);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>Task of ResultString</returns>
        System.Threading.Tasks.Task<ResultString> UserLoginAsync (string name, string password);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>Task of ApiResponse (ResultString)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResultString>> UserLoginAsyncWithHttpInfo (string name, string password);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Result</returns>
        Result UserLogout ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Result</returns>
        ApiResponse<Result> UserLogoutWithHttpInfo ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of Result</returns>
        System.Threading.Tasks.Task<Result> UserLogoutAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (Result)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result>> UserLogoutAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>Result</returns>
        Result UserSendMailRestorePassword (string name);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>ApiResponse of Result</returns>
        ApiResponse<Result> UserSendMailRestorePasswordWithHttpInfo (string name);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>Task of Result</returns>
        System.Threading.Tasks.Task<Result> UserSendMailRestorePasswordAsync (string name);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result>> UserSendMailRestorePasswordAsyncWithHttpInfo (string name);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token"></param>
        /// <param name="password"></param>
        /// <returns>Result</returns>
        Result UserRestorePassword (string token, string password);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token"></param>
        /// <param name="password"></param>
        /// <returns>ApiResponse of Result</returns>
        ApiResponse<Result> UserRestorePasswordWithHttpInfo (string token, string password);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token"></param>
        /// <param name="password"></param>
        /// <returns>Task of Result</returns>
        System.Threading.Tasks.Task<Result> UserRestorePasswordAsync (string token, string password);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token"></param>
        /// <param name="password"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result>> UserRestorePasswordAsyncWithHttpInfo (string token, string password);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserApi(Configuration configuration = null)
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
        /// <param name="oldpassword"></param> 
        /// <param name="password"></param> 
        /// <returns>Result</returns>
        public Result UserChangePassword (string oldpassword, string password)
        {
             ApiResponse<Result> response = UserChangePasswordWithHttpInfo(oldpassword, password);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="oldpassword"></param> 
        /// <param name="password"></param> 
        /// <returns>ApiResponse of Result</returns>
        public ApiResponse< Result > UserChangePasswordWithHttpInfo (string oldpassword, string password)
        {
            
            // verify the required parameter 'oldpassword' is set
            if (oldpassword == null)
                throw new ApiException(400, "Missing required parameter 'oldpassword' when calling UserApi->UserChangePassword");
            
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UserApi->UserChangePassword");
            
    
            var path_ = "/api/user/changepassword";
    
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
            
            if (oldpassword != null) queryParams.Add("oldpassword", Configuration.ApiClient.ParameterToString(oldpassword)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserChangePassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserChangePassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="oldpassword"></param>
        /// <param name="password"></param>
        /// <returns>Task of Result</returns>
        public async System.Threading.Tasks.Task<Result> UserChangePasswordAsync (string oldpassword, string password)
        {
             ApiResponse<Result> response = await UserChangePasswordAsyncWithHttpInfo(oldpassword, password);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="oldpassword"></param>
        /// <param name="password"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Result>> UserChangePasswordAsyncWithHttpInfo (string oldpassword, string password)
        {
            // verify the required parameter 'oldpassword' is set
            if (oldpassword == null) throw new ApiException(400, "Missing required parameter 'oldpassword' when calling UserChangePassword");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling UserChangePassword");
            
    
            var path_ = "/api/user/changepassword";
    
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
            
            if (oldpassword != null) queryParams.Add("oldpassword", Configuration.ApiClient.ParameterToString(oldpassword)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserChangePassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserChangePassword: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="token"></param> 
        /// <returns>ResultBool</returns>
        public ResultBool UserCheckToken (string token)
        {
             ApiResponse<ResultBool> response = UserCheckTokenWithHttpInfo(token);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="token"></param> 
        /// <returns>ApiResponse of ResultBool</returns>
        public ApiResponse< ResultBool > UserCheckTokenWithHttpInfo (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling UserApi->UserCheckToken");
            
    
            var path_ = "/api/user/checktoken";
    
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
            
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserCheckToken: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserCheckToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResultBool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResultBool) Configuration.ApiClient.Deserialize(response, typeof(ResultBool)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="token"></param>
        /// <returns>Task of ResultBool</returns>
        public async System.Threading.Tasks.Task<ResultBool> UserCheckTokenAsync (string token)
        {
             ApiResponse<ResultBool> response = await UserCheckTokenAsyncWithHttpInfo(token);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="token"></param>
        /// <returns>Task of ApiResponse (ResultBool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResultBool>> UserCheckTokenAsyncWithHttpInfo (string token)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UserCheckToken");
            
    
            var path_ = "/api/user/checktoken";
    
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
            
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserCheckToken: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserCheckToken: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResultBool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResultBool) Configuration.ApiClient.Deserialize(response, typeof(ResultBool)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="password"></param> 
        /// <param name="email"></param> 
        /// <returns>Result</returns>
        public Result UserCreate (string name, string password, string email)
        {
             ApiResponse<Result> response = UserCreateWithHttpInfo(name, password, email);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="password"></param> 
        /// <param name="email"></param> 
        /// <returns>ApiResponse of Result</returns>
        public ApiResponse< Result > UserCreateWithHttpInfo (string name, string password, string email)
        {
            
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling UserApi->UserCreate");
            
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UserApi->UserCreate");
            
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UserApi->UserCreate");
            
    
            var path_ = "/api/user/create";
    
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
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserCreate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns>Task of Result</returns>
        public async System.Threading.Tasks.Task<Result> UserCreateAsync (string name, string password, string email)
        {
             ApiResponse<Result> response = await UserCreateAsyncWithHttpInfo(name, password, email);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Result>> UserCreateAsyncWithHttpInfo (string name, string password, string email)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UserCreate");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling UserCreate");
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling UserCreate");
            
    
            var path_ = "/api/user/create";
    
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
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserCreate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserCreate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Result</returns>
        public Result UserCurrentUser ()
        {
             ApiResponse<Result> response = UserCurrentUserWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>ApiResponse of Result</returns>
        public ApiResponse< Result > UserCurrentUserWithHttpInfo ()
        {
            
    
            var path_ = "/api/user/currentuser";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserCurrentUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserCurrentUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of Result</returns>
        public async System.Threading.Tasks.Task<Result> UserCurrentUserAsync ()
        {
             ApiResponse<Result> response = await UserCurrentUserAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of ApiResponse (Result)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Result>> UserCurrentUserAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/user/currentuser";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserCurrentUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserCurrentUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <returns>ResultBool</returns>
        public ResultBool UserIsDefaultUserEnabled ()
        {
             ApiResponse<ResultBool> response = UserIsDefaultUserEnabledWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>ApiResponse of ResultBool</returns>
        public ApiResponse< ResultBool > UserIsDefaultUserEnabledWithHttpInfo ()
        {
            
    
            var path_ = "/api/user/isdefaultuserenabled";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserIsDefaultUserEnabled: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserIsDefaultUserEnabled: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResultBool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResultBool) Configuration.ApiClient.Deserialize(response, typeof(ResultBool)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of ResultBool</returns>
        public async System.Threading.Tasks.Task<ResultBool> UserIsDefaultUserEnabledAsync ()
        {
             ApiResponse<ResultBool> response = await UserIsDefaultUserEnabledAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of ApiResponse (ResultBool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResultBool>> UserIsDefaultUserEnabledAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/user/isdefaultuserenabled";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserIsDefaultUserEnabled: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserIsDefaultUserEnabled: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResultBool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResultBool) Configuration.ApiClient.Deserialize(response, typeof(ResultBool)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="password"></param> 
        /// <returns>ResultString</returns>
        public ResultString UserLogin (string name, string password)
        {
             ApiResponse<ResultString> response = UserLoginWithHttpInfo(name, password);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="password"></param> 
        /// <returns>ApiResponse of ResultString</returns>
        public ApiResponse< ResultString > UserLoginWithHttpInfo (string name, string password)
        {
            
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling UserApi->UserLogin");
            
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UserApi->UserLogin");
            
    
            var path_ = "/api/user/login";
    
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
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserLogin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserLogin: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResultString>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResultString) Configuration.ApiClient.Deserialize(response, typeof(ResultString)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>Task of ResultString</returns>
        public async System.Threading.Tasks.Task<ResultString> UserLoginAsync (string name, string password)
        {
             ApiResponse<ResultString> response = await UserLoginAsyncWithHttpInfo(name, password);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>Task of ApiResponse (ResultString)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResultString>> UserLoginAsyncWithHttpInfo (string name, string password)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UserLogin");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling UserLogin");
            
    
            var path_ = "/api/user/login";
    
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
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserLogin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserLogin: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResultString>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResultString) Configuration.ApiClient.Deserialize(response, typeof(ResultString)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Result</returns>
        public Result UserLogout ()
        {
             ApiResponse<Result> response = UserLogoutWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>ApiResponse of Result</returns>
        public ApiResponse< Result > UserLogoutWithHttpInfo ()
        {
            
    
            var path_ = "/api/user/logout";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserLogout: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserLogout: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of Result</returns>
        public async System.Threading.Tasks.Task<Result> UserLogoutAsync ()
        {
             ApiResponse<Result> response = await UserLogoutAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of ApiResponse (Result)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Result>> UserLogoutAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/user/logout";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserLogout: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserLogout: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <returns>Result</returns>
        public Result UserSendMailRestorePassword (string name)
        {
             ApiResponse<Result> response = UserSendMailRestorePasswordWithHttpInfo(name);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <returns>ApiResponse of Result</returns>
        public ApiResponse< Result > UserSendMailRestorePasswordWithHttpInfo (string name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling UserApi->UserSendMailRestorePassword");
            
    
            var path_ = "/api/user/preparerestore";
    
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
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserSendMailRestorePassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserSendMailRestorePassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Task of Result</returns>
        public async System.Threading.Tasks.Task<Result> UserSendMailRestorePasswordAsync (string name)
        {
             ApiResponse<Result> response = await UserSendMailRestorePasswordAsyncWithHttpInfo(name);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Result>> UserSendMailRestorePasswordAsyncWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UserSendMailRestorePassword");
            
    
            var path_ = "/api/user/preparerestore";
    
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
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserSendMailRestorePassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserSendMailRestorePassword: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="token"></param> 
        /// <param name="password"></param> 
        /// <returns>Result</returns>
        public Result UserRestorePassword (string token, string password)
        {
             ApiResponse<Result> response = UserRestorePasswordWithHttpInfo(token, password);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="token"></param> 
        /// <param name="password"></param> 
        /// <returns>ApiResponse of Result</returns>
        public ApiResponse< Result > UserRestorePasswordWithHttpInfo (string token, string password)
        {
            
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling UserApi->UserRestorePassword");
            
            // verify the required parameter 'password' is set
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling UserApi->UserRestorePassword");
            
    
            var path_ = "/api/user/restorepassword";
    
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
            
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserRestorePassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserRestorePassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="token"></param>
        /// <param name="password"></param>
        /// <returns>Task of Result</returns>
        public async System.Threading.Tasks.Task<Result> UserRestorePasswordAsync (string token, string password)
        {
             ApiResponse<Result> response = await UserRestorePasswordAsyncWithHttpInfo(token, password);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="token"></param>
        /// <param name="password"></param>
        /// <returns>Task of ApiResponse (Result)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Result>> UserRestorePasswordAsyncWithHttpInfo (string token, string password)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UserRestorePassword");
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling UserRestorePassword");
            
    
            var path_ = "/api/user/restorepassword";
    
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
            
            if (token != null) queryParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // query parameter
            if (password != null) queryParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserRestorePassword: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserRestorePassword: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Result>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(response, typeof(Result)));
            
        }
        
    }
    
}
