# IO.Swagger.Api.TechpreviewServicesApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewServicesControlPost**](TechpreviewServicesApi.md#appliancetechpreviewservicescontrolpost) | **POST** /appliance/techpreview/services/control | Services-control
[**ApplianceTechpreviewServicesGet**](TechpreviewServicesApi.md#appliancetechpreviewservicesget) | **GET** /appliance/techpreview/services | Services
[**ApplianceTechpreviewServicesRestartPost**](TechpreviewServicesApi.md#appliancetechpreviewservicesrestartpost) | **POST** /appliance/techpreview/services/restart | Services-restart
[**ApplianceTechpreviewServicesStatusGetPost**](TechpreviewServicesApi.md#appliancetechpreviewservicesstatusgetpost) | **POST** /appliance/techpreview/services/status/get | Services-getspecificservicedetails
[**ApplianceTechpreviewServicesStopPost**](TechpreviewServicesApi.md#appliancetechpreviewservicesstoppost) | **POST** /appliance/techpreview/services/stop | Services-stop


<a name="appliancetechpreviewservicescontrolpost"></a>
# **ApplianceTechpreviewServicesControlPost**
> void ApplianceTechpreviewServicesControlPost (string contentType, ServicesControlRequest body)

Services-control

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
    public class ApplianceTechpreviewServicesControlPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewServicesApi();
            var contentType = contentType_example;  // string | 
            var body = new ServicesControlRequest(); // ServicesControlRequest | 

            try
            {
                // Services-control
                apiInstance.ApplianceTechpreviewServicesControlPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewServicesApi.ApplianceTechpreviewServicesControlPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ServicesControlRequest**](ServicesControlRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewservicesget"></a>
# **ApplianceTechpreviewServicesGet**
> void ApplianceTechpreviewServicesGet (string contentType)

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
    public class ApplianceTechpreviewServicesGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewServicesApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Services
                apiInstance.ApplianceTechpreviewServicesGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewServicesApi.ApplianceTechpreviewServicesGet: " + e.Message );
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

<a name="appliancetechpreviewservicesrestartpost"></a>
# **ApplianceTechpreviewServicesRestartPost**
> void ApplianceTechpreviewServicesRestartPost (string contentType, ServicesRestartRequest body)

Services-restart

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
    public class ApplianceTechpreviewServicesRestartPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewServicesApi();
            var contentType = contentType_example;  // string | 
            var body = new ServicesRestartRequest(); // ServicesRestartRequest | 

            try
            {
                // Services-restart
                apiInstance.ApplianceTechpreviewServicesRestartPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewServicesApi.ApplianceTechpreviewServicesRestartPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ServicesRestartRequest**](ServicesRestartRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewservicesstatusgetpost"></a>
# **ApplianceTechpreviewServicesStatusGetPost**
> void ApplianceTechpreviewServicesStatusGetPost (string contentType, ServicesGetspecificservicedetailsRequest body)

Services-getspecificservicedetails

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
    public class ApplianceTechpreviewServicesStatusGetPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewServicesApi();
            var contentType = contentType_example;  // string | 
            var body = new ServicesGetspecificservicedetailsRequest(); // ServicesGetspecificservicedetailsRequest | 

            try
            {
                // Services-getspecificservicedetails
                apiInstance.ApplianceTechpreviewServicesStatusGetPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewServicesApi.ApplianceTechpreviewServicesStatusGetPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ServicesGetspecificservicedetailsRequest**](ServicesGetspecificservicedetailsRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewservicesstoppost"></a>
# **ApplianceTechpreviewServicesStopPost**
> void ApplianceTechpreviewServicesStopPost (string contentType, ServicesStopRequest body)

Services-stop

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
    public class ApplianceTechpreviewServicesStopPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewServicesApi();
            var contentType = contentType_example;  // string | 
            var body = new ServicesStopRequest(); // ServicesStopRequest | 

            try
            {
                // Services-stop
                apiInstance.ApplianceTechpreviewServicesStopPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewServicesApi.ApplianceTechpreviewServicesStopPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ServicesStopRequest**](ServicesStopRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

