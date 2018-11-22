using netvmomi.Client;
using RestSharp;
using System.Collections.Generic;

namespace netvmomi.API {
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi {
        /// <summary>
        /// Logout Logout of the specified vCenter
        /// </summary>
        /// <returns></returns>
        void ComVmwareCisSessionDelete();
        /// <summary>
        /// Login Login to the specified vCenter and retrieve a session
        /// </summary>
        /// <returns></returns>
        void ComVmwareCisSessionPost();
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthenticationApi : IAuthenticationApi {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthenticationApi(ApiClient apiClient = null) {
            if (apiClient == null) // use the default one in Configuration
{
                ApiClient = Configuration.DefaultApiClient;
            } else {
                ApiClient = apiClient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(string basePath) {
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
        /// Logout Logout of the specified vCenter
        /// </summary>
        /// <returns></returns>            
        public void ComVmwareCisSessionDelete() {


            string path = "/com/vmware/cis/session";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;


            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ComVmwareCisSessionDelete: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ComVmwareCisSessionDelete: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Login Login to the specified vCenter and retrieve a session
        /// </summary>
        /// <returns></returns>            
        public void ComVmwareCisSessionPost() {


            string path = "/com/vmware/cis/session";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;


            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ComVmwareCisSessionPost: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ComVmwareCisSessionPost: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

    }
}
