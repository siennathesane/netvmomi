using netvmomi.Client;
using RestSharp;
using System;
using System.Collections.Generic;

namespace netvmomi.API {
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMonitoringApi {
        /// <summary>
        /// List TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceMonitoringGet(string contentType);
        /// <summary>
        /// Detailsfor:netRXeth0 TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceMonitoringNetRxActivityEth0Get(string contentType);
        /// <summary>
        /// Querystatsfor:neteth0 TODO: Add Description
        /// </summary>
        /// <param name="itemInterval"></param>
        /// <param name="itemEndTime"></param>
        /// <param name="itemNames1"></param>
        /// <param name="itemNames2"></param>
        /// <param name="itemStartTime"></param>
        /// <param name="itemFunction"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceMonitoringQueryGet(string itemInterval, DateTime? itemEndTime, string itemNames1, string itemNames2, DateTime? itemStartTime, string itemFunction, string contentType);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MonitoringApi : IMonitoringApi {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MonitoringApi(ApiClient apiClient = null) {
            if (apiClient == null) // use the default one in Configuration
{
                ApiClient = Configuration.DefaultApiClient;
            } else {
                ApiClient = apiClient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MonitoringApi(string basePath) {
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
        /// List TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceMonitoringGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceMonitoringGet");
            }

            string path = "/appliance/monitoring";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceMonitoringGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceMonitoringGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Detailsfor:netRXeth0 TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceMonitoringNetRxActivityEth0Get(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceMonitoringNetRxActivityEth0Get");
            }

            string path = "/appliance/monitoring/net.rx.activity.eth0";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceMonitoringNetRxActivityEth0Get: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceMonitoringNetRxActivityEth0Get: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Querystatsfor:neteth0 TODO: Add Description
        /// </summary>
        /// <param name="itemInterval"></param> 
        /// <param name="itemEndTime"></param> 
        /// <param name="itemNames1"></param> 
        /// <param name="itemNames2"></param> 
        /// <param name="itemStartTime"></param> 
        /// <param name="itemFunction"></param> 
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceMonitoringQueryGet(string itemInterval, DateTime? itemEndTime, string itemNames1, string itemNames2, DateTime? itemStartTime, string itemFunction, string contentType) {

            // verify the required parameter 'itemInterval' is set
            if (itemInterval == null) {
                throw new ApiException(400, "Missing required parameter 'itemInterval' when calling ApplianceMonitoringQueryGet");
            }

            // verify the required parameter 'itemEndTime' is set
            if (itemEndTime == null) {
                throw new ApiException(400, "Missing required parameter 'itemEndTime' when calling ApplianceMonitoringQueryGet");
            }

            // verify the required parameter 'itemNames1' is set
            if (itemNames1 == null) {
                throw new ApiException(400, "Missing required parameter 'itemNames1' when calling ApplianceMonitoringQueryGet");
            }

            // verify the required parameter 'itemNames2' is set
            if (itemNames2 == null) {
                throw new ApiException(400, "Missing required parameter 'itemNames2' when calling ApplianceMonitoringQueryGet");
            }

            // verify the required parameter 'itemStartTime' is set
            if (itemStartTime == null) {
                throw new ApiException(400, "Missing required parameter 'itemStartTime' when calling ApplianceMonitoringQueryGet");
            }

            // verify the required parameter 'itemFunction' is set
            if (itemFunction == null) {
                throw new ApiException(400, "Missing required parameter 'itemFunction' when calling ApplianceMonitoringQueryGet");
            }

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceMonitoringQueryGet");
            }

            string path = "/appliance/monitoring/query";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (itemInterval != null) {
                queryParams.Add("item.interval", ApiClient.ParameterToString(itemInterval)); // query parameter
            }

            if (itemEndTime != null) {
                queryParams.Add("item.end_time", ApiClient.ParameterToString(itemEndTime)); // query parameter
            }

            if (itemNames1 != null) {
                queryParams.Add("item.names.1", ApiClient.ParameterToString(itemNames1)); // query parameter
            }

            if (itemNames2 != null) {
                queryParams.Add("item.names.2", ApiClient.ParameterToString(itemNames2)); // query parameter
            }

            if (itemStartTime != null) {
                queryParams.Add("item.start_time", ApiClient.ParameterToString(itemStartTime)); // query parameter
            }

            if (itemFunction != null) {
                queryParams.Add("item.function", ApiClient.ParameterToString(itemFunction)); // query parameter
            }

            if (contentType != null) {
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            }

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceMonitoringQueryGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceMonitoringQueryGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

    }
}
