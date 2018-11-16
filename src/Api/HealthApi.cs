using netvmomi.Client;
using RestSharp;
using System.Collections.Generic;

namespace netvmomi.API {
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHealthApi {
        /// <summary>
        /// Applianceservices TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceHealthApplmgmtGet(string contentType);
        /// <summary>
        /// Databasestorage TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceHealthDatabaseStorageGet(string contentType);
        /// <summary>
        /// Load TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceHealthLoadGet(string contentType);
        /// <summary>
        /// Memory TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceHealthMemGet(string contentType);
        /// <summary>
        /// Softwarepackagesupdates TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceHealthSoftwarePackagesGet(string contentType);
        /// <summary>
        /// Storage TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceHealthStorageGet(string contentType);
        /// <summary>
        /// Swap TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceHealthSwapGet(string contentType);
        /// <summary>
        /// System TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceHealthSystemGet(string contentType);
        /// <summary>
        /// Systemlastcheck TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceHealthSystemLastcheckGet(string contentType);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HealthApi : IHealthApi {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HealthApi(ApiClient apiClient = null) {
            if (apiClient == null) // use the default one in Configuration
{
                ApiClient = Configuration.DefaultApiClient;
            } else {
                ApiClient = apiClient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HealthApi(string basePath) {
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
        /// Applianceservices TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceHealthApplmgmtGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceHealthApplmgmtGet");
            }

            string path = "/appliance/health/applmgmt";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthApplmgmtGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthApplmgmtGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Databasestorage TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceHealthDatabaseStorageGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceHealthDatabaseStorageGet");
            }

            string path = "/appliance/health/database-storage";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthDatabaseStorageGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthDatabaseStorageGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Load TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceHealthLoadGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceHealthLoadGet");
            }

            string path = "/appliance/health/load";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthLoadGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthLoadGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Memory TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceHealthMemGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceHealthMemGet");
            }

            string path = "/appliance/health/mem";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthMemGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthMemGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Softwarepackagesupdates TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceHealthSoftwarePackagesGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceHealthSoftwarePackagesGet");
            }

            string path = "/appliance/health/software-packages";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthSoftwarePackagesGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthSoftwarePackagesGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Storage TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceHealthStorageGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceHealthStorageGet");
            }

            string path = "/appliance/health/storage";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthStorageGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthStorageGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Swap TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceHealthSwapGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceHealthSwapGet");
            }

            string path = "/appliance/health/swap";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthSwapGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthSwapGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// System TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceHealthSystemGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceHealthSystemGet");
            }

            string path = "/appliance/health/system";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthSystemGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthSystemGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Systemlastcheck TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceHealthSystemLastcheckGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceHealthSystemLastcheckGet");
            }

            string path = "/appliance/health/system/lastcheck";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthSystemLastcheckGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceHealthSystemLastcheckGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

    }
}
