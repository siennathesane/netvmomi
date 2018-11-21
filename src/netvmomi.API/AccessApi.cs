using netvmomi.Client;
using netvmomi.Model;
using RestSharp;
using System.Collections.Generic;

namespace netvmomi.API {
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccessApi {
        /// <summary>
        /// ConsoleCLI TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceAccessConsolecliGet(string contentType);
        /// <summary>
        /// ConsoleCLI-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceAccessConsolecliPut(string contentType, ConsoleCLIDisableRequest body);
        /// <summary>
        /// DCUI TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceAccessDcuiGet(string contentType);
        /// <summary>
        /// DCUI-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceAccessDcuiPut(string contentType, DCUIDisableRequest body);
        /// <summary>
        /// Shell TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceAccessShellGet(string contentType);
        /// <summary>
        /// Shell-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceAccessShellPut(string contentType, ShellDisableRequest body);
        /// <summary>
        /// SSH TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceAccessSshGet(string contentType);
        /// <summary>
        /// SSH-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceAccessSshPut(string contentType, SSHDisableRequest body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccessApi : IAccessApi {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccessApi(ApiClient apiClient = null) {
            if (apiClient == null) // use the default one in Configuration
{
                ApiClient = Configuration.DefaultApiClient;
            } else {
                ApiClient = apiClient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccessApi(string basePath) {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(string basePath) {
            ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public string GetBasePath(string basePath) {
            return ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// ConsoleCLI TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceAccessConsolecliGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceAccessConsolecliGet");
            }

            string path = "/appliance/access/consolecli";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (contentType != null) {
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            }

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessConsolecliGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessConsolecliGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// ConsoleCLI-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceAccessConsolecliPut(string contentType, ConsoleCLIDisableRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceAccessConsolecliPut");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceAccessConsolecliPut");
            }

            string path = "/appliance/access/consolecli";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (contentType != null) {
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            }

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessConsolecliPut: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessConsolecliPut: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// DCUI TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceAccessDcuiGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceAccessDcuiGet");
            }

            string path = "/appliance/access/dcui";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (contentType != null) {
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            }

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessDcuiGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessDcuiGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// DCUI-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceAccessDcuiPut(string contentType, DCUIDisableRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceAccessDcuiPut");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceAccessDcuiPut");
            }

            string path = "/appliance/access/dcui";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (contentType != null) {
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            }

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessDcuiPut: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessDcuiPut: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Shell TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceAccessShellGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceAccessShellGet");
            }

            string path = "/appliance/access/shell";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (contentType != null) {
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            }

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessShellGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessShellGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Shell-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceAccessShellPut(string contentType, ShellDisableRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceAccessShellPut");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceAccessShellPut");
            }

            string path = "/appliance/access/shell";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (contentType != null) {
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            }

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessShellPut: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessShellPut: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// SSH TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceAccessSshGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceAccessSshGet");
            }

            string path = "/appliance/access/ssh";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (contentType != null) {
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            }

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessSshGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessSshGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// SSH-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceAccessSshPut(string contentType, SSHDisableRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceAccessSshPut");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceAccessSshPut");
            }

            string path = "/appliance/access/ssh";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (contentType != null) {
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            }

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessSshPut: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessSshPut: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

    }
}
