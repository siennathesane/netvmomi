# IO.Swagger.Api.RecoveryApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceRecoveryBackupJobByApplianceBackupjobIdGet**](RecoveryApi.md#appliancerecoverybackupjobbyappliancebackupjobidget) | **GET** /appliance/recovery/backup/job/{appliance_backupjob_id} | Backupjob-status
[**ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost**](RecoveryApi.md#appliancerecoverybackupjobcancelbyappliancebackupjobidpost) | **POST** /appliance/recovery/backup/job/{appliance_backupjob_id}/cancel | Backupjob-cancel
[**ApplianceRecoveryBackupJobDetailsGet**](RecoveryApi.md#appliancerecoverybackupjobdetailsget) | **GET** /appliance/recovery/backup/job/details | Backupjob-details
[**ApplianceRecoveryBackupJobGet**](RecoveryApi.md#appliancerecoverybackupjobget) | **GET** /appliance/recovery/backup/job | Backupjob
[**ApplianceRecoveryBackupJobPost**](RecoveryApi.md#appliancerecoverybackupjobpost) | **POST** /appliance/recovery/backup/job | Backupjob-create
[**ApplianceRecoveryBackupPartsByBackupPartsIdGet**](RecoveryApi.md#appliancerecoverybackuppartsbybackuppartsidget) | **GET** /appliance/recovery/backup/parts/{backup-parts-id} | Backupparts-sizeofspecficpart
[**ApplianceRecoveryBackupPartsGet**](RecoveryApi.md#appliancerecoverybackuppartsget) | **GET** /appliance/recovery/backup/parts | Backupparts
[**ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete**](RecoveryApi.md#appliancerecoverybackupschedulesbybackupscheduleiddelete) | **DELETE** /appliance/recovery/backup/schedules/{backup-schedule-id} | Backupschedule-remove
[**ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet**](RecoveryApi.md#appliancerecoverybackupschedulesbybackupscheduleidget) | **GET** /appliance/recovery/backup/schedules/{backup-schedule-id} | Backupschedule-details
[**ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost**](RecoveryApi.md#appliancerecoverybackupschedulesbybackupscheduleidpost) | **POST** /appliance/recovery/backup/schedules/{backup-schedule-id} | Backupschedule-create
[**ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut**](RecoveryApi.md#appliancerecoverybackupschedulesbybackupscheduleidput) | **PUT** /appliance/recovery/backup/schedules/{backup-schedule-id} | Backupschedule-update
[**ApplianceRecoveryBackupSchedulesGet**](RecoveryApi.md#appliancerecoverybackupschedulesget) | **GET** /appliance/recovery/backup/schedules | Backupschedule
[**ApplianceRecoveryBackupValidatePost**](RecoveryApi.md#appliancerecoverybackupvalidatepost) | **POST** /appliance/recovery/backup/validate | Backupjob-validate
[**ApplianceRecoveryRestoreJobCancelPost**](RecoveryApi.md#appliancerecoveryrestorejobcancelpost) | **POST** /appliance/recovery/restore/job/cancel | Restorejob-cancel
[**ApplianceRecoveryRestoreJobGet**](RecoveryApi.md#appliancerecoveryrestorejobget) | **GET** /appliance/recovery/restore/job | Restorejob
[**ApplianceRecoveryRestoreJobPost**](RecoveryApi.md#appliancerecoveryrestorejobpost) | **POST** /appliance/recovery/restore/job | Restorejob-create


<a name="appliancerecoverybackupjobbyappliancebackupjobidget"></a>
# **ApplianceRecoveryBackupJobByApplianceBackupjobIdGet**
> void ApplianceRecoveryBackupJobByApplianceBackupjobIdGet (string contentType, string applianceBackupjobId)

Backupjob-status

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupJobByApplianceBackupjobIdGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 
            var applianceBackupjobId = applianceBackupjobId_example;  // string | 

            try
            {
                // Backupjob-status
                apiInstance.ApplianceRecoveryBackupJobByApplianceBackupjobIdGet(contentType, applianceBackupjobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupJobByApplianceBackupjobIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **applianceBackupjobId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackupjobcancelbyappliancebackupjobidpost"></a>
# **ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost**
> void ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost (string contentType, string applianceBackupjobId)

Backupjob-cancel

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 
            var applianceBackupjobId = applianceBackupjobId_example;  // string | 

            try
            {
                // Backupjob-cancel
                apiInstance.ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost(contentType, applianceBackupjobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **applianceBackupjobId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackupjobdetailsget"></a>
# **ApplianceRecoveryBackupJobDetailsGet**
> void ApplianceRecoveryBackupJobDetailsGet (string contentType)

Backupjob-details

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupJobDetailsGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Backupjob-details
                apiInstance.ApplianceRecoveryBackupJobDetailsGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupJobDetailsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackupjobget"></a>
# **ApplianceRecoveryBackupJobGet**
> void ApplianceRecoveryBackupJobGet (string contentType)

Backupjob

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupJobGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Backupjob
                apiInstance.ApplianceRecoveryBackupJobGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupJobGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackupjobpost"></a>
# **ApplianceRecoveryBackupJobPost**
> void ApplianceRecoveryBackupJobPost (string contentType, BackupjobCreateRequest body)

Backupjob-create

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupJobPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 
            var body = new BackupjobCreateRequest(); // BackupjobCreateRequest | 

            try
            {
                // Backupjob-create
                apiInstance.ApplianceRecoveryBackupJobPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupJobPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**BackupjobCreateRequest**](BackupjobCreateRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackuppartsbybackuppartsidget"></a>
# **ApplianceRecoveryBackupPartsByBackupPartsIdGet**
> void ApplianceRecoveryBackupPartsByBackupPartsIdGet (string contentType, string backupPartsId)

Backupparts-sizeofspecficpart

Get size of the optional part

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupPartsByBackupPartsIdGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 
            var backupPartsId = backupPartsId_example;  // string | 

            try
            {
                // Backupparts-sizeofspecficpart
                apiInstance.ApplianceRecoveryBackupPartsByBackupPartsIdGet(contentType, backupPartsId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupPartsByBackupPartsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **backupPartsId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackuppartsget"></a>
# **ApplianceRecoveryBackupPartsGet**
> void ApplianceRecoveryBackupPartsGet (string contentType)

Backupparts

Get a list of the backup parts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupPartsGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Backupparts
                apiInstance.ApplianceRecoveryBackupPartsGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupPartsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackupschedulesbybackupscheduleiddelete"></a>
# **ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete**
> void ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete (string contentType, string backupScheduleId)

Backupschedule-remove

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupSchedulesByBackupScheduleIdDeleteExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 
            var backupScheduleId = backupScheduleId_example;  // string | 

            try
            {
                // Backupschedule-remove
                apiInstance.ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete(contentType, backupScheduleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **backupScheduleId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackupschedulesbybackupscheduleidget"></a>
# **ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet**
> void ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet (string contentType, string backupScheduleId)

Backupschedule-details

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupSchedulesByBackupScheduleIdGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 
            var backupScheduleId = backupScheduleId_example;  // string | 

            try
            {
                // Backupschedule-details
                apiInstance.ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet(contentType, backupScheduleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **backupScheduleId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackupschedulesbybackupscheduleidpost"></a>
# **ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost**
> void ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost (string contentType, BackupscheduleCreateRequest body, string backupScheduleId)

Backupschedule-create

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupSchedulesByBackupScheduleIdPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 
            var body = new BackupscheduleCreateRequest(); // BackupscheduleCreateRequest | 
            var backupScheduleId = backupScheduleId_example;  // string | 

            try
            {
                // Backupschedule-create
                apiInstance.ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost(contentType, body, backupScheduleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**BackupscheduleCreateRequest**](BackupscheduleCreateRequest.md)|  | 
 **backupScheduleId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackupschedulesbybackupscheduleidput"></a>
# **ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut**
> void ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut (string contentType, BackupscheduleUpdateRequest body, string backupScheduleId)

Backupschedule-update

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupSchedulesByBackupScheduleIdPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 
            var body = new BackupscheduleUpdateRequest(); // BackupscheduleUpdateRequest | 
            var backupScheduleId = backupScheduleId_example;  // string | 

            try
            {
                // Backupschedule-update
                apiInstance.ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut(contentType, body, backupScheduleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**BackupscheduleUpdateRequest**](BackupscheduleUpdateRequest.md)|  | 
 **backupScheduleId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackupschedulesget"></a>
# **ApplianceRecoveryBackupSchedulesGet**
> void ApplianceRecoveryBackupSchedulesGet (string contentType)

Backupschedule

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupSchedulesGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Backupschedule
                apiInstance.ApplianceRecoveryBackupSchedulesGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupSchedulesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoverybackupvalidatepost"></a>
# **ApplianceRecoveryBackupValidatePost**
> void ApplianceRecoveryBackupValidatePost (string contentType, BackupjobValidateRequest body)

Backupjob-validate

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryBackupValidatePostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 
            var body = new BackupjobValidateRequest(); // BackupjobValidateRequest | 

            try
            {
                // Backupjob-validate
                apiInstance.ApplianceRecoveryBackupValidatePost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryBackupValidatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**BackupjobValidateRequest**](BackupjobValidateRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoveryrestorejobcancelpost"></a>
# **ApplianceRecoveryRestoreJobCancelPost**
> void ApplianceRecoveryRestoreJobCancelPost (string contentType)

Restorejob-cancel

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryRestoreJobCancelPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Restorejob-cancel
                apiInstance.ApplianceRecoveryRestoreJobCancelPost(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryRestoreJobCancelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoveryrestorejobget"></a>
# **ApplianceRecoveryRestoreJobGet**
> void ApplianceRecoveryRestoreJobGet (string contentType)

Restorejob

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryRestoreJobGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Restorejob
                apiInstance.ApplianceRecoveryRestoreJobGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryRestoreJobGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancerecoveryrestorejobpost"></a>
# **ApplianceRecoveryRestoreJobPost**
> void ApplianceRecoveryRestoreJobPost (string contentType, RestorejobCreateRequest body)

Restorejob-create

TODO: Add Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceRecoveryRestoreJobPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RecoveryApi();
            var contentType = contentType_example;  // string | 
            var body = new RestorejobCreateRequest(); // RestorejobCreateRequest | 

            try
            {
                // Restorejob-create
                apiInstance.ApplianceRecoveryRestoreJobPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryApi.ApplianceRecoveryRestoreJobPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**RestorejobCreateRequest**](RestorejobCreateRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

