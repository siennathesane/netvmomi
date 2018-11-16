# IO.Swagger.Api.SystemApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceSystemStorageGet**](SystemApi.md#appliancesystemstorageget) | **GET** /appliance/system/storage | Storage
[**ApplianceSystemStorageResizePost**](SystemApi.md#appliancesystemstorageresizepost) | **POST** /appliance/system/storage/resize | Storage-resize
[**ApplianceSystemTimeGet**](SystemApi.md#appliancesystemtimeget) | **GET** /appliance/system/time | Time
[**ApplianceSystemUptimeGet**](SystemApi.md#appliancesystemuptimeget) | **GET** /appliance/system/uptime | Uptime
[**ApplianceSystemVersionGet**](SystemApi.md#appliancesystemversionget) | **GET** /appliance/system/version | Version


<a name="appliancesystemstorageget"></a>
# **ApplianceSystemStorageGet**
> void ApplianceSystemStorageGet (string contentType)

Storage

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
    public class ApplianceSystemStorageGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Storage
                apiInstance.ApplianceSystemStorageGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.ApplianceSystemStorageGet: " + e.Message );
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

<a name="appliancesystemstorageresizepost"></a>
# **ApplianceSystemStorageResizePost**
> void ApplianceSystemStorageResizePost (string contentType)

Storage-resize

Resize all partitions to 100 percent of disk size

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceSystemStorageResizePostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Storage-resize
                apiInstance.ApplianceSystemStorageResizePost(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.ApplianceSystemStorageResizePost: " + e.Message );
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

<a name="appliancesystemtimeget"></a>
# **ApplianceSystemTimeGet**
> void ApplianceSystemTimeGet (string contentType)

Time

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
    public class ApplianceSystemTimeGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Time
                apiInstance.ApplianceSystemTimeGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.ApplianceSystemTimeGet: " + e.Message );
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

<a name="appliancesystemuptimeget"></a>
# **ApplianceSystemUptimeGet**
> void ApplianceSystemUptimeGet (string contentType)

Uptime

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
    public class ApplianceSystemUptimeGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Uptime
                apiInstance.ApplianceSystemUptimeGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.ApplianceSystemUptimeGet: " + e.Message );
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

<a name="appliancesystemversionget"></a>
# **ApplianceSystemVersionGet**
> void ApplianceSystemVersionGet (string contentType)

Version

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
    public class ApplianceSystemVersionGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Version
                apiInstance.ApplianceSystemVersionGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.ApplianceSystemVersionGet: " + e.Message );
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

