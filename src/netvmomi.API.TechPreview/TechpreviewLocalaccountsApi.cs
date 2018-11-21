using netvmomi.Client;
using netvmomi.Model;
using RestSharp;
using System.Collections.Generic;

namespace netvmomi.API {
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITechpreviewLocalaccountsApi {
        /// <summary>
        /// Localaccounts-details TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="applianceLocalUser"></param>
        /// <returns></returns>
        void ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet(string contentType, string applianceLocalUser);
        /// <summary>
        /// Localaccounts TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceTechpreviewLocalAccountsUserGet(string contentType);
        /// <summary>
        /// Localaccounts-create TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceTechpreviewLocalAccountsUserPost(string contentType, LocalaccountsCreateRequest body);
        /// <summary>
        /// Localaccounts-update TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceTechpreviewLocalAccountsUserPut(string contentType, LocalaccountsUpdateRequest body);
        /// <summary>
        /// Localaccounts-remove TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceTechpreviewLocalAccountsUserTestDelete(string contentType);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TechpreviewLocalaccountsApi : ITechpreviewLocalaccountsApi {
        /// <summary>
        /// Initializes a new instance of the <see cref="TechpreviewLocalaccountsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TechpreviewLocalaccountsApi(ApiClient apiClient = null) {
            if (apiClient == null) // use the default one in Configuration
{
                ApiClient = Configuration.DefaultApiClient;
            } else {
                ApiClient = apiClient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechpreviewLocalaccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TechpreviewLocalaccountsApi(string basePath) {
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
        /// Localaccounts-details TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="applianceLocalUser"></param> 
        /// <returns></returns>            
        public void ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet(string contentType, string applianceLocalUser) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet");
            }

            // verify the required parameter 'applianceLocalUser' is set
            if (applianceLocalUser == null) {
                throw new ApiException(400, "Missing required parameter 'applianceLocalUser' when calling ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet");
            }

            string path = "/appliance/techpreview/local-accounts/user/{appliance_local_user}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "appliance_local_user" + "}", ApiClient.ParameterToString(applianceLocalUser));

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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Localaccounts TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceTechpreviewLocalAccountsUserGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceTechpreviewLocalAccountsUserGet");
            }

            string path = "/appliance/techpreview/local-accounts/user";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewLocalAccountsUserGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewLocalAccountsUserGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Localaccounts-create TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceTechpreviewLocalAccountsUserPost(string contentType, LocalaccountsCreateRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceTechpreviewLocalAccountsUserPost");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceTechpreviewLocalAccountsUserPost");
            }

            string path = "/appliance/techpreview/local-accounts/user";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewLocalAccountsUserPost: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewLocalAccountsUserPost: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Localaccounts-update TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceTechpreviewLocalAccountsUserPut(string contentType, LocalaccountsUpdateRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceTechpreviewLocalAccountsUserPut");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceTechpreviewLocalAccountsUserPut");
            }

            string path = "/appliance/techpreview/local-accounts/user";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewLocalAccountsUserPut: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewLocalAccountsUserPut: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Localaccounts-remove TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceTechpreviewLocalAccountsUserTestDelete(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceTechpreviewLocalAccountsUserTestDelete");
            }

            string path = "/appliance/techpreview/local-accounts/user/test";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewLocalAccountsUserTestDelete: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewLocalAccountsUserTestDelete: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

    }
}
