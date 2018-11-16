# IO.Swagger.Api.TechpreviewPoweroperationsApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewShutdownCancelPost**](TechpreviewPoweroperationsApi.md#appliancetechpreviewshutdowncancelpost) | **POST** /appliance/techpreview/shutdown/cancel | Shutdown-cancel
[**ApplianceTechpreviewShutdownGet**](TechpreviewPoweroperationsApi.md#appliancetechpreviewshutdownget) | **GET** /appliance/techpreview/shutdown | Shutdownoperations
[**ApplianceTechpreviewShutdownPoweroffPost**](TechpreviewPoweroperationsApi.md#appliancetechpreviewshutdownpoweroffpost) | **POST** /appliance/techpreview/shutdown/poweroff | Shutdown
[**ApplianceTechpreviewShutdownRestartPost**](TechpreviewPoweroperationsApi.md#appliancetechpreviewshutdownrestartpost) | **POST** /appliance/techpreview/shutdown/restart | Restart


<a name="appliancetechpreviewshutdowncancelpost"></a>
# **ApplianceTechpreviewShutdownCancelPost**
> void ApplianceTechpreviewShutdownCancelPost (string contentType)

Shutdown-cancel

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
    public class ApplianceTechpreviewShutdownCancelPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewPoweroperationsApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Shutdown-cancel
                apiInstance.ApplianceTechpreviewShutdownCancelPost(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewPoweroperationsApi.ApplianceTechpreviewShutdownCancelPost: " + e.Message );
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

<a name="appliancetechpreviewshutdownget"></a>
# **ApplianceTechpreviewShutdownGet**
> void ApplianceTechpreviewShutdownGet (string contentType)

Shutdownoperations

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
    public class ApplianceTechpreviewShutdownGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewPoweroperationsApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Shutdownoperations
                apiInstance.ApplianceTechpreviewShutdownGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewPoweroperationsApi.ApplianceTechpreviewShutdownGet: " + e.Message );
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

<a name="appliancetechpreviewshutdownpoweroffpost"></a>
# **ApplianceTechpreviewShutdownPoweroffPost**
> void ApplianceTechpreviewShutdownPoweroffPost (string contentType, ShutdownRequest body)

Shutdown

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
    public class ApplianceTechpreviewShutdownPoweroffPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewPoweroperationsApi();
            var contentType = contentType_example;  // string | 
            var body = new ShutdownRequest(); // ShutdownRequest | 

            try
            {
                // Shutdown
                apiInstance.ApplianceTechpreviewShutdownPoweroffPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewPoweroperationsApi.ApplianceTechpreviewShutdownPoweroffPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ShutdownRequest**](ShutdownRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewshutdownrestartpost"></a>
# **ApplianceTechpreviewShutdownRestartPost**
> void ApplianceTechpreviewShutdownRestartPost (string contentType, RestartRequest body)

Restart

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
    public class ApplianceTechpreviewShutdownRestartPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewPoweroperationsApi();
            var contentType = contentType_example;  // string | 
            var body = new RestartRequest(); // RestartRequest | 

            try
            {
                // Restart
                apiInstance.ApplianceTechpreviewShutdownRestartPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewPoweroperationsApi.ApplianceTechpreviewShutdownRestartPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**RestartRequest**](RestartRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

