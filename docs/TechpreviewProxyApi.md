# IO.Swagger.Api.TechpreviewProxyApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewNetworkingProxyDeletePost**](TechpreviewProxyApi.md#appliancetechpreviewnetworkingproxydeletepost) | **POST** /appliance/techpreview/networking/proxy/delete | Proxy-delete
[**ApplianceTechpreviewNetworkingProxyGet**](TechpreviewProxyApi.md#appliancetechpreviewnetworkingproxyget) | **GET** /appliance/techpreview/networking/proxy | Getproxyconfigurations
[**ApplianceTechpreviewNetworkingProxyPut**](TechpreviewProxyApi.md#appliancetechpreviewnetworkingproxyput) | **PUT** /appliance/techpreview/networking/proxy | Proxy-set
[**ApplianceTechpreviewNetworkingProxyTestPost**](TechpreviewProxyApi.md#appliancetechpreviewnetworkingproxytestpost) | **POST** /appliance/techpreview/networking/proxy/test | Proxy-test


<a name="appliancetechpreviewnetworkingproxydeletepost"></a>
# **ApplianceTechpreviewNetworkingProxyDeletePost**
> void ApplianceTechpreviewNetworkingProxyDeletePost (string contentType, ProxyDeleteRequest body)

Proxy-delete

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
    public class ApplianceTechpreviewNetworkingProxyDeletePostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewProxyApi();
            var contentType = contentType_example;  // string | 
            var body = new ProxyDeleteRequest(); // ProxyDeleteRequest | 

            try
            {
                // Proxy-delete
                apiInstance.ApplianceTechpreviewNetworkingProxyDeletePost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewProxyApi.ApplianceTechpreviewNetworkingProxyDeletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ProxyDeleteRequest**](ProxyDeleteRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewnetworkingproxyget"></a>
# **ApplianceTechpreviewNetworkingProxyGet**
> void ApplianceTechpreviewNetworkingProxyGet (string contentType)

Getproxyconfigurations

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
    public class ApplianceTechpreviewNetworkingProxyGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewProxyApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Getproxyconfigurations
                apiInstance.ApplianceTechpreviewNetworkingProxyGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewProxyApi.ApplianceTechpreviewNetworkingProxyGet: " + e.Message );
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

<a name="appliancetechpreviewnetworkingproxyput"></a>
# **ApplianceTechpreviewNetworkingProxyPut**
> void ApplianceTechpreviewNetworkingProxyPut (string contentType, ProxySetRequest body)

Proxy-set

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
    public class ApplianceTechpreviewNetworkingProxyPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewProxyApi();
            var contentType = contentType_example;  // string | 
            var body = new ProxySetRequest(); // ProxySetRequest | 

            try
            {
                // Proxy-set
                apiInstance.ApplianceTechpreviewNetworkingProxyPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewProxyApi.ApplianceTechpreviewNetworkingProxyPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ProxySetRequest**](ProxySetRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewnetworkingproxytestpost"></a>
# **ApplianceTechpreviewNetworkingProxyTestPost**
> void ApplianceTechpreviewNetworkingProxyTestPost (string contentType, ProxyTestRequest body)

Proxy-test

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
    public class ApplianceTechpreviewNetworkingProxyTestPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewProxyApi();
            var contentType = contentType_example;  // string | 
            var body = new ProxyTestRequest(); // ProxyTestRequest | 

            try
            {
                // Proxy-test
                apiInstance.ApplianceTechpreviewNetworkingProxyTestPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewProxyApi.ApplianceTechpreviewNetworkingProxyTestPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ProxyTestRequest**](ProxyTestRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

