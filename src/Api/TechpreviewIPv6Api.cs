using netvmomi.Client;
using netvmomi.Model;
using RestSharp;
using System.Collections.Generic;

namespace netvmomi.API {
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITechpreviewIPv6Api {
        /// <summary>
        /// IPv6 TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceTechpreviewNetworkingIpv6Get(string contentType);
        /// <summary>
        /// IPv6-details TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceTechpreviewNetworkingIpv6GetPost(string contentType, IPv4DetailsRequest body);
        /// <summary>
        /// IPv6-set TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceTechpreviewNetworkingIpv6Post(string contentType, IPv6SetRequest body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TechpreviewIPv6Api : ITechpreviewIPv6Api {
        /// <summary>
        /// Initializes a new instance of the <see cref="TechpreviewIPv6Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TechpreviewIPv6Api(ApiClient apiClient = null) {
            if (apiClient == null) // use the default one in Configuration
{
                ApiClient = Configuration.DefaultApiClient;
            } else {
                ApiClient = apiClient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechpreviewIPv6Api"/> class.
        /// </summary>
        /// <returns></returns>
        public TechpreviewIPv6Api(string basePath) {
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
        /// IPv6 TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceTechpreviewNetworkingIpv6Get(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceTechpreviewNetworkingIpv6Get");
            }

            string path = "/appliance/techpreview/networking/ipv6";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewNetworkingIpv6Get: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewNetworkingIpv6Get: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// IPv6-details TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceTechpreviewNetworkingIpv6GetPost(string contentType, IPv4DetailsRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceTechpreviewNetworkingIpv6GetPost");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceTechpreviewNetworkingIpv6GetPost");
            }

            string path = "/appliance/techpreview/networking/ipv6/get";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewNetworkingIpv6GetPost: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewNetworkingIpv6GetPost: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// IPv6-set TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceTechpreviewNetworkingIpv6Post(string contentType, IPv6SetRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceTechpreviewNetworkingIpv6Post");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceTechpreviewNetworkingIpv6Post");
            }

            string path = "/appliance/techpreview/networking/ipv6";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewNetworkingIpv6Post: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceTechpreviewNetworkingIpv6Post: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

    }
}
