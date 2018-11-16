using netvmomi.Client;
using netvmomi.Model;
using RestSharp;
using System.Collections.Generic;

namespace netvmomi.API {
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRecoveryApi {
        /// <summary>
        /// Backupjob-status TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="applianceBackupjobId"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupJobByApplianceBackupjobIdGet(string contentType, string applianceBackupjobId);
        /// <summary>
        /// Backupjob-cancel TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="applianceBackupjobId"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost(string contentType, string applianceBackupjobId);
        /// <summary>
        /// Backupjob-details TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupJobDetailsGet(string contentType);
        /// <summary>
        /// Backupjob TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupJobGet(string contentType);
        /// <summary>
        /// Backupjob-create TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupJobPost(string contentType, BackupjobCreateRequest body);
        /// <summary>
        /// Backupparts-sizeofspecficpart Get size of the optional part
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="backupPartsId"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupPartsByBackupPartsIdGet(string contentType, string backupPartsId);
        /// <summary>
        /// Backupparts Get a list of the backup parts
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupPartsGet(string contentType);
        /// <summary>
        /// Backupschedule-remove TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="backupScheduleId"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete(string contentType, string backupScheduleId);
        /// <summary>
        /// Backupschedule-details TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="backupScheduleId"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet(string contentType, string backupScheduleId);
        /// <summary>
        /// Backupschedule-create TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <param name="backupScheduleId"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost(string contentType, BackupscheduleCreateRequest body, string backupScheduleId);
        /// <summary>
        /// Backupschedule-update TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <param name="backupScheduleId"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut(string contentType, BackupscheduleUpdateRequest body, string backupScheduleId);
        /// <summary>
        /// Backupschedule TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupSchedulesGet(string contentType);
        /// <summary>
        /// Backupjob-validate TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceRecoveryBackupValidatePost(string contentType, BackupjobValidateRequest body);
        /// <summary>
        /// Restorejob-cancel TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceRecoveryRestoreJobCancelPost(string contentType);
        /// <summary>
        /// Restorejob TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceRecoveryRestoreJobGet(string contentType);
        /// <summary>
        /// Restorejob-create TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceRecoveryRestoreJobPost(string contentType, RestorejobCreateRequest body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RecoveryApi : IRecoveryApi {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoveryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RecoveryApi(ApiClient apiClient = null) {
            if (apiClient == null) // use the default one in Configuration
{
                ApiClient = Configuration.DefaultApiClient;
            } else {
                ApiClient = apiClient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecoveryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecoveryApi(string basePath) {
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
        /// Backupjob-status TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="applianceBackupjobId"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupJobByApplianceBackupjobIdGet(string contentType, string applianceBackupjobId) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupJobByApplianceBackupjobIdGet");
            }

            // verify the required parameter 'applianceBackupjobId' is set
            if (applianceBackupjobId == null) {
                throw new ApiException(400, "Missing required parameter 'applianceBackupjobId' when calling ApplianceRecoveryBackupJobByApplianceBackupjobIdGet");
            }

            string path = "/appliance/recovery/backup/job/{appliance_backupjob_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "appliance_backupjob_id" + "}", ApiClient.ParameterToString(applianceBackupjobId));

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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupJobByApplianceBackupjobIdGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupJobByApplianceBackupjobIdGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupjob-cancel TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="applianceBackupjobId"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost(string contentType, string applianceBackupjobId) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost");
            }

            // verify the required parameter 'applianceBackupjobId' is set
            if (applianceBackupjobId == null) {
                throw new ApiException(400, "Missing required parameter 'applianceBackupjobId' when calling ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost");
            }

            string path = "/appliance/recovery/backup/job/{appliance_backupjob_id}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "appliance_backupjob_id" + "}", ApiClient.ParameterToString(applianceBackupjobId));

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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupjob-details TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupJobDetailsGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupJobDetailsGet");
            }

            string path = "/appliance/recovery/backup/job/details";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupJobDetailsGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupJobDetailsGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupjob TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupJobGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupJobGet");
            }

            string path = "/appliance/recovery/backup/job";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupJobGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupJobGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupjob-create TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupJobPost(string contentType, BackupjobCreateRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupJobPost");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceRecoveryBackupJobPost");
            }

            string path = "/appliance/recovery/backup/job";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupJobPost: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupJobPost: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupparts-sizeofspecficpart Get size of the optional part
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="backupPartsId"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupPartsByBackupPartsIdGet(string contentType, string backupPartsId) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupPartsByBackupPartsIdGet");
            }

            // verify the required parameter 'backupPartsId' is set
            if (backupPartsId == null) {
                throw new ApiException(400, "Missing required parameter 'backupPartsId' when calling ApplianceRecoveryBackupPartsByBackupPartsIdGet");
            }

            string path = "/appliance/recovery/backup/parts/{backup-parts-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "backup-parts-id" + "}", ApiClient.ParameterToString(backupPartsId));

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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupPartsByBackupPartsIdGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupPartsByBackupPartsIdGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupparts Get a list of the backup parts
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupPartsGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupPartsGet");
            }

            string path = "/appliance/recovery/backup/parts";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupPartsGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupPartsGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupschedule-remove TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="backupScheduleId"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete(string contentType, string backupScheduleId) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete");
            }

            // verify the required parameter 'backupScheduleId' is set
            if (backupScheduleId == null) {
                throw new ApiException(400, "Missing required parameter 'backupScheduleId' when calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete");
            }

            string path = "/appliance/recovery/backup/schedules/{backup-schedule-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "backup-schedule-id" + "}", ApiClient.ParameterToString(backupScheduleId));

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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupschedule-details TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="backupScheduleId"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet(string contentType, string backupScheduleId) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet");
            }

            // verify the required parameter 'backupScheduleId' is set
            if (backupScheduleId == null) {
                throw new ApiException(400, "Missing required parameter 'backupScheduleId' when calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet");
            }

            string path = "/appliance/recovery/backup/schedules/{backup-schedule-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "backup-schedule-id" + "}", ApiClient.ParameterToString(backupScheduleId));

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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupschedule-create TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <param name="backupScheduleId"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost(string contentType, BackupscheduleCreateRequest body, string backupScheduleId) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost");
            }

            // verify the required parameter 'backupScheduleId' is set
            if (backupScheduleId == null) {
                throw new ApiException(400, "Missing required parameter 'backupScheduleId' when calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost");
            }

            string path = "/appliance/recovery/backup/schedules/{backup-schedule-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "backup-schedule-id" + "}", ApiClient.ParameterToString(backupScheduleId));

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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupschedule-update TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <param name="backupScheduleId"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut(string contentType, BackupscheduleUpdateRequest body, string backupScheduleId) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut");
            }

            // verify the required parameter 'backupScheduleId' is set
            if (backupScheduleId == null) {
                throw new ApiException(400, "Missing required parameter 'backupScheduleId' when calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut");
            }

            string path = "/appliance/recovery/backup/schedules/{backup-schedule-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "backup-schedule-id" + "}", ApiClient.ParameterToString(backupScheduleId));

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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupschedule TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupSchedulesGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupSchedulesGet");
            }

            string path = "/appliance/recovery/backup/schedules";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupSchedulesGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupSchedulesGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Backupjob-validate TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryBackupValidatePost(string contentType, BackupjobValidateRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryBackupValidatePost");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceRecoveryBackupValidatePost");
            }

            string path = "/appliance/recovery/backup/validate";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupValidatePost: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryBackupValidatePost: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Restorejob-cancel TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryRestoreJobCancelPost(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryRestoreJobCancelPost");
            }

            string path = "/appliance/recovery/restore/job/cancel";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryRestoreJobCancelPost: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryRestoreJobCancelPost: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Restorejob TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryRestoreJobGet(string contentType) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryRestoreJobGet");
            }

            string path = "/appliance/recovery/restore/job";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryRestoreJobGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryRestoreJobGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Restorejob-create TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceRecoveryRestoreJobPost(string contentType, RestorejobCreateRequest body) {

            // verify the required parameter 'contentType' is set
            if (contentType == null) {
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ApplianceRecoveryRestoreJobPost");
            }

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceRecoveryRestoreJobPost");
            }

            string path = "/appliance/recovery/restore/job";
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
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryRestoreJobPost: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceRecoveryRestoreJobPost: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

    }
}
