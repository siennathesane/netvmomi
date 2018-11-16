# IO.Swagger.Api.TechpreviewRoutesApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewNetworkingRoutesDeletePost**](TechpreviewRoutesApi.md#appliancetechpreviewnetworkingroutesdeletepost) | **POST** /appliance/techpreview/networking/routes/delete | Routes-delete
[**ApplianceTechpreviewNetworkingRoutesGet**](TechpreviewRoutesApi.md#appliancetechpreviewnetworkingroutesget) | **GET** /appliance/techpreview/networking/routes | List
[**ApplianceTechpreviewNetworkingRoutesPost**](TechpreviewRoutesApi.md#appliancetechpreviewnetworkingroutespost) | **POST** /appliance/techpreview/networking/routes | Routes-add
[**ApplianceTechpreviewNetworkingRoutesPut**](TechpreviewRoutesApi.md#appliancetechpreviewnetworkingroutesput) | **PUT** /appliance/techpreview/networking/routes | Set
[**ApplianceTechpreviewNetworkingRoutesTestPost**](TechpreviewRoutesApi.md#appliancetechpreviewnetworkingroutestestpost) | **POST** /appliance/techpreview/networking/routes/test | Routes-test


<a name="appliancetechpreviewnetworkingroutesdeletepost"></a>
# **ApplianceTechpreviewNetworkingRoutesDeletePost**
> void ApplianceTechpreviewNetworkingRoutesDeletePost (string contentType, RoutesDeleteRequest body)

Routes-delete

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
    public class ApplianceTechpreviewNetworkingRoutesDeletePostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewRoutesApi();
            var contentType = contentType_example;  // string | 
            var body = new RoutesDeleteRequest(); // RoutesDeleteRequest | 

            try
            {
                // Routes-delete
                apiInstance.ApplianceTechpreviewNetworkingRoutesDeletePost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewRoutesApi.ApplianceTechpreviewNetworkingRoutesDeletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**RoutesDeleteRequest**](RoutesDeleteRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewnetworkingroutesget"></a>
# **ApplianceTechpreviewNetworkingRoutesGet**
> void ApplianceTechpreviewNetworkingRoutesGet (string contentType)

List

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
    public class ApplianceTechpreviewNetworkingRoutesGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewRoutesApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // List
                apiInstance.ApplianceTechpreviewNetworkingRoutesGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewRoutesApi.ApplianceTechpreviewNetworkingRoutesGet: " + e.Message );
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

<a name="appliancetechpreviewnetworkingroutespost"></a>
# **ApplianceTechpreviewNetworkingRoutesPost**
> void ApplianceTechpreviewNetworkingRoutesPost (string contentType, RoutesAddRequest body)

Routes-add

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
    public class ApplianceTechpreviewNetworkingRoutesPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewRoutesApi();
            var contentType = contentType_example;  // string | 
            var body = new RoutesAddRequest(); // RoutesAddRequest | 

            try
            {
                // Routes-add
                apiInstance.ApplianceTechpreviewNetworkingRoutesPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewRoutesApi.ApplianceTechpreviewNetworkingRoutesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**RoutesAddRequest**](RoutesAddRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewnetworkingroutesput"></a>
# **ApplianceTechpreviewNetworkingRoutesPut**
> void ApplianceTechpreviewNetworkingRoutesPut (string contentType, SetRequest body)

Set

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
    public class ApplianceTechpreviewNetworkingRoutesPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewRoutesApi();
            var contentType = contentType_example;  // string | 
            var body = new SetRequest(); // SetRequest | 

            try
            {
                // Set
                apiInstance.ApplianceTechpreviewNetworkingRoutesPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewRoutesApi.ApplianceTechpreviewNetworkingRoutesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**SetRequest**](SetRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewnetworkingroutestestpost"></a>
# **ApplianceTechpreviewNetworkingRoutesTestPost**
> void ApplianceTechpreviewNetworkingRoutesTestPost (string contentType, RoutesTestRequest body)

Routes-test

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
    public class ApplianceTechpreviewNetworkingRoutesTestPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewRoutesApi();
            var contentType = contentType_example;  // string | 
            var body = new RoutesTestRequest(); // RoutesTestRequest | 

            try
            {
                // Routes-test
                apiInstance.ApplianceTechpreviewNetworkingRoutesTestPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewRoutesApi.ApplianceTechpreviewNetworkingRoutesTestPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**RoutesTestRequest**](RoutesTestRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

