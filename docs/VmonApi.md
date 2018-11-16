# IO.Swagger.Api.VmonApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceVmonServiceContentLibraryGet**](VmonApi.md#appliancevmonservicecontentlibraryget) | **GET** /appliance/vmon/service/content-library | Getdetailsaboutspecificservice
[**ApplianceVmonServiceContentLibraryPatch**](VmonApi.md#appliancevmonservicecontentlibrarypatch) | **PATCH** /appliance/vmon/service/content-library | Updatespecificservice
[**ApplianceVmonServiceContentLibraryRestartPost**](VmonApi.md#appliancevmonservicecontentlibraryrestartpost) | **POST** /appliance/vmon/service/content-library/restart | Restartspecificservice
[**ApplianceVmonServiceContentLibraryStartPost**](VmonApi.md#appliancevmonservicecontentlibrarystartpost) | **POST** /appliance/vmon/service/content-library/start | Startspecificservice
[**ApplianceVmonServiceContentLibraryStopPost**](VmonApi.md#appliancevmonservicecontentlibrarystoppost) | **POST** /appliance/vmon/service/content-library/stop | Stopspecificservice
[**ApplianceVmonServiceGet**](VmonApi.md#appliancevmonserviceget) | **GET** /appliance/vmon/service | Services


<a name="appliancevmonservicecontentlibraryget"></a>
# **ApplianceVmonServiceContentLibraryGet**
> void ApplianceVmonServiceContentLibraryGet (string contentType)

Getdetailsaboutspecificservice

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
    public class ApplianceVmonServiceContentLibraryGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VmonApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Getdetailsaboutspecificservice
                apiInstance.ApplianceVmonServiceContentLibraryGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VmonApi.ApplianceVmonServiceContentLibraryGet: " + e.Message );
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

<a name="appliancevmonservicecontentlibrarypatch"></a>
# **ApplianceVmonServiceContentLibraryPatch**
> void ApplianceVmonServiceContentLibraryPatch (string contentType, UpdatespecificserviceRequest body)

Updatespecificservice

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
    public class ApplianceVmonServiceContentLibraryPatchExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VmonApi();
            var contentType = contentType_example;  // string | 
            var body = new UpdatespecificserviceRequest(); // UpdatespecificserviceRequest | 

            try
            {
                // Updatespecificservice
                apiInstance.ApplianceVmonServiceContentLibraryPatch(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VmonApi.ApplianceVmonServiceContentLibraryPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**UpdatespecificserviceRequest**](UpdatespecificserviceRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancevmonservicecontentlibraryrestartpost"></a>
# **ApplianceVmonServiceContentLibraryRestartPost**
> void ApplianceVmonServiceContentLibraryRestartPost (string contentType)

Restartspecificservice

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
    public class ApplianceVmonServiceContentLibraryRestartPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VmonApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Restartspecificservice
                apiInstance.ApplianceVmonServiceContentLibraryRestartPost(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VmonApi.ApplianceVmonServiceContentLibraryRestartPost: " + e.Message );
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

<a name="appliancevmonservicecontentlibrarystartpost"></a>
# **ApplianceVmonServiceContentLibraryStartPost**
> void ApplianceVmonServiceContentLibraryStartPost (string contentType)

Startspecificservice

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
    public class ApplianceVmonServiceContentLibraryStartPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VmonApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Startspecificservice
                apiInstance.ApplianceVmonServiceContentLibraryStartPost(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VmonApi.ApplianceVmonServiceContentLibraryStartPost: " + e.Message );
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

<a name="appliancevmonservicecontentlibrarystoppost"></a>
# **ApplianceVmonServiceContentLibraryStopPost**
> void ApplianceVmonServiceContentLibraryStopPost (string contentType)

Stopspecificservice

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
    public class ApplianceVmonServiceContentLibraryStopPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VmonApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Stopspecificservice
                apiInstance.ApplianceVmonServiceContentLibraryStopPost(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VmonApi.ApplianceVmonServiceContentLibraryStopPost: " + e.Message );
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

<a name="appliancevmonserviceget"></a>
# **ApplianceVmonServiceGet**
> void ApplianceVmonServiceGet (string contentType)

Services

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
    public class ApplianceVmonServiceGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VmonApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Services
                apiInstance.ApplianceVmonServiceGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VmonApi.ApplianceVmonServiceGet: " + e.Message );
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

