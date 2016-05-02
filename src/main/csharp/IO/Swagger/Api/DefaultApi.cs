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
    public interface IDefaultApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activity"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Response</returns>
        Response ActivitiesPost (Activity activity, string authorization = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activity"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> ActivitiesPostWithHttpInfo (Activity activity, string authorization = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityRecord"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Response</returns>
        Response ActivitiesRecordsPost (ActivityRecord activityRecord, string authorization = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityRecord"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> ActivitiesRecordsPostWithHttpInfo (ActivityRecord activityRecord, string authorization = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns></returns>
        void ContactsPost (Contact contact, string authorization = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContactsPostWithHttpInfo (Contact contact, string authorization = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Contact</returns>
        Contact ContactsPut (Contact contact, string authorization = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>ApiResponse of Contact</returns>
        ApiResponse<Contact> ContactsPutWithHttpInfo (Contact contact, string authorization = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>MessageResponse</returns>
        MessageResponse MessagesPost (Message message, string authorization = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>ApiResponse of MessageResponse</returns>
        ApiResponse<MessageResponse> MessagesPostWithHttpInfo (Message message, string authorization = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activity"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> ActivitiesPostAsync (Activity activity, string authorization = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activity"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> ActivitiesPostAsyncWithHttpInfo (Activity activity, string authorization = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityRecord"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> ActivitiesRecordsPostAsync (ActivityRecord activityRecord, string authorization = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityRecord"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> ActivitiesRecordsPostAsyncWithHttpInfo (ActivityRecord activityRecord, string authorization = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContactsPostAsync (Contact contact, string authorization = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContactsPostAsyncWithHttpInfo (Contact contact, string authorization = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of Contact</returns>
        System.Threading.Tasks.Task<Contact> ContactsPutAsync (Contact contact, string authorization = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        System.Threading.Tasks.Task<ApiResponse<Contact>> ContactsPutAsyncWithHttpInfo (Contact contact, string authorization = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of MessageResponse</returns>
        System.Threading.Tasks.Task<MessageResponse> MessagesPostAsync (Message message, string authorization = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageResponse>> MessagesPostAsyncWithHttpInfo (Message message, string authorization = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activity"></param> 
        /// <param name="authorization"> (optional)</param> 
        /// <returns>Response</returns>
        public Response ActivitiesPost (Activity activity, string authorization = null)
        {
             ApiResponse<Response> localVarResponse = ActivitiesPostWithHttpInfo(activity, authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activity"></param> 
        /// <param name="authorization"> (optional)</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > ActivitiesPostWithHttpInfo (Activity activity, string authorization = null)
        {
            
            // verify the required parameter 'activity' is set
            if (activity == null)
                throw new ApiException(400, "Missing required parameter 'activity' when calling DefaultApi->ActivitiesPost");
            
    
            var localVarPath = "/activities";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            if (activity.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(activity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = activity; // byte array
            }

            // authentication (ShoutOUTCustomAuthorizer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ActivitiesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ActivitiesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activity"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> ActivitiesPostAsync (Activity activity, string authorization = null)
        {
             ApiResponse<Response> localVarResponse = await ActivitiesPostAsyncWithHttpInfo(activity, authorization);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activity"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> ActivitiesPostAsyncWithHttpInfo (Activity activity, string authorization = null)
        {
            // verify the required parameter 'activity' is set
            if (activity == null) throw new ApiException(400, "Missing required parameter 'activity' when calling ActivitiesPost");
            
    
            var localVarPath = "/activities";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            if (activity.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(activity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = activity; // byte array
            }

            
            // authentication (ShoutOUTCustomAuthorizer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ActivitiesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ActivitiesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityRecord"></param> 
        /// <param name="authorization"> (optional)</param> 
        /// <returns>Response</returns>
        public Response ActivitiesRecordsPost (ActivityRecord activityRecord, string authorization = null)
        {
             ApiResponse<Response> localVarResponse = ActivitiesRecordsPostWithHttpInfo(activityRecord, authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityRecord"></param> 
        /// <param name="authorization"> (optional)</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > ActivitiesRecordsPostWithHttpInfo (ActivityRecord activityRecord, string authorization = null)
        {
            
            // verify the required parameter 'activityRecord' is set
            if (activityRecord == null)
                throw new ApiException(400, "Missing required parameter 'activityRecord' when calling DefaultApi->ActivitiesRecordsPost");
            
    
            var localVarPath = "/activities/records";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            if (activityRecord.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(activityRecord); // http body (model) parameter
            }
            else
            {
                localVarPostBody = activityRecord; // byte array
            }

            // authentication (ShoutOUTCustomAuthorizer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ActivitiesRecordsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ActivitiesRecordsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityRecord"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> ActivitiesRecordsPostAsync (ActivityRecord activityRecord, string authorization = null)
        {
             ApiResponse<Response> localVarResponse = await ActivitiesRecordsPostAsyncWithHttpInfo(activityRecord, authorization);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityRecord"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> ActivitiesRecordsPostAsyncWithHttpInfo (ActivityRecord activityRecord, string authorization = null)
        {
            // verify the required parameter 'activityRecord' is set
            if (activityRecord == null) throw new ApiException(400, "Missing required parameter 'activityRecord' when calling ActivitiesRecordsPost");
            
    
            var localVarPath = "/activities/records";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            if (activityRecord.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(activityRecord); // http body (model) parameter
            }
            else
            {
                localVarPostBody = activityRecord; // byte array
            }

            
            // authentication (ShoutOUTCustomAuthorizer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ActivitiesRecordsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ActivitiesRecordsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param> 
        /// <param name="authorization"> (optional)</param> 
        /// <returns></returns>
        public void ContactsPost (Contact contact, string authorization = null)
        {
             ContactsPostWithHttpInfo(contact, authorization);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param> 
        /// <param name="authorization"> (optional)</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContactsPostWithHttpInfo (Contact contact, string authorization = null)
        {
            
            // verify the required parameter 'contact' is set
            if (contact == null)
                throw new ApiException(400, "Missing required parameter 'contact' when calling DefaultApi->ContactsPost");
            
    
            var localVarPath = "/contacts";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            if (contact.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contact); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contact; // byte array
            }

            // authentication (ShoutOUTCustomAuthorizer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContactsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContactsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContactsPostAsync (Contact contact, string authorization = null)
        {
             await ContactsPostAsyncWithHttpInfo(contact, authorization);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContactsPostAsyncWithHttpInfo (Contact contact, string authorization = null)
        {
            // verify the required parameter 'contact' is set
            if (contact == null) throw new ApiException(400, "Missing required parameter 'contact' when calling ContactsPost");
            
    
            var localVarPath = "/contacts";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            if (contact.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contact); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contact; // byte array
            }

            
            // authentication (ShoutOUTCustomAuthorizer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContactsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContactsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param> 
        /// <param name="authorization"> (optional)</param> 
        /// <returns>Contact</returns>
        public Contact ContactsPut (Contact contact, string authorization = null)
        {
             ApiResponse<Contact> localVarResponse = ContactsPutWithHttpInfo(contact, authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param> 
        /// <param name="authorization"> (optional)</param> 
        /// <returns>ApiResponse of Contact</returns>
        public ApiResponse< Contact > ContactsPutWithHttpInfo (Contact contact, string authorization = null)
        {
            
            // verify the required parameter 'contact' is set
            if (contact == null)
                throw new ApiException(400, "Missing required parameter 'contact' when calling DefaultApi->ContactsPut");
            
    
            var localVarPath = "/contacts";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            if (contact.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contact); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contact; // byte array
            }

            // authentication (ShoutOUTCustomAuthorizer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContactsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContactsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Contact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Contact)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of Contact</returns>
        public async System.Threading.Tasks.Task<Contact> ContactsPutAsync (Contact contact, string authorization = null)
        {
             ApiResponse<Contact> localVarResponse = await ContactsPutAsyncWithHttpInfo(contact, authorization);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contact>> ContactsPutAsyncWithHttpInfo (Contact contact, string authorization = null)
        {
            // verify the required parameter 'contact' is set
            if (contact == null) throw new ApiException(400, "Missing required parameter 'contact' when calling ContactsPut");
            
    
            var localVarPath = "/contacts";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            if (contact.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contact); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contact; // byte array
            }

            
            // authentication (ShoutOUTCustomAuthorizer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContactsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContactsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Contact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Contact)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message"></param> 
        /// <param name="authorization"> (optional)</param> 
        /// <returns>MessageResponse</returns>
        public MessageResponse MessagesPost (Message message, string authorization = null)
        {
             ApiResponse<MessageResponse> localVarResponse = MessagesPostWithHttpInfo(message, authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message"></param> 
        /// <param name="authorization"> (optional)</param> 
        /// <returns>ApiResponse of MessageResponse</returns>
        public ApiResponse< MessageResponse > MessagesPostWithHttpInfo (Message message, string authorization = null)
        {
            
            // verify the required parameter 'message' is set
            if (message == null)
                throw new ApiException(400, "Missing required parameter 'message' when calling DefaultApi->MessagesPost");
            
    
            var localVarPath = "/messages";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            if (message.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(message); // http body (model) parameter
            }
            else
            {
                localVarPostBody = message; // byte array
            }

            // authentication (ShoutOUTCustomAuthorizer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling MessagesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling MessagesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MessageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageResponse)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of MessageResponse</returns>
        public async System.Threading.Tasks.Task<MessageResponse> MessagesPostAsync (Message message, string authorization = null)
        {
             ApiResponse<MessageResponse> localVarResponse = await MessagesPostAsyncWithHttpInfo(message, authorization);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message"></param>
        /// <param name="authorization"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageResponse>> MessagesPostAsyncWithHttpInfo (Message message, string authorization = null)
        {
            // verify the required parameter 'message' is set
            if (message == null) throw new ApiException(400, "Missing required parameter 'message' when calling MessagesPost");
            
    
            var localVarPath = "/messages";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            if (message.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(message); // http body (model) parameter
            }
            else
            {
                localVarPostBody = message; // byte array
            }

            
            // authentication (ShoutOUTCustomAuthorizer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling MessagesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling MessagesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageResponse)));
            
        }
        
    }
    
}
