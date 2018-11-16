# IO.Swagger.Api.TechpreviewIPv6Api

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewNetworkingIpv6Get**](TechpreviewIPv6Api.md#appliancetechpreviewnetworkingipv6get) | **GET** /appliance/techpreview/networking/ipv6 | IPv6
[**ApplianceTechpreviewNetworkingIpv6GetPost**](TechpreviewIPv6Api.md#appliancetechpreviewnetworkingipv6getpost) | **POST** /appliance/techpreview/networking/ipv6/get | IPv6-details
[**ApplianceTechpreviewNetworkingIpv6Post**](TechpreviewIPv6Api.md#appliancetechpreviewnetworkingipv6post) | **POST** /appliance/techpreview/networking/ipv6 | IPv6-set


<a name="appliancetechpreviewnetworkingipv6get"></a>
# **ApplianceTechpreviewNetworkingIpv6Get**
> void ApplianceTechpreviewNetworkingIpv6Get (string contentType)

IPv6

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
    public class ApplianceTechpreviewNetworkingIpv6GetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewIPv6Api();
            var contentType = contentType_example;  // string | 

            try
            {
                // IPv6
                apiInstance.ApplianceTechpreviewNetworkingIpv6Get(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewIPv6Api.ApplianceTechpreviewNetworkingIpv6Get: " + e.Message );
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

<a name="appliancetechpreviewnetworkingipv6getpost"></a>
# **ApplianceTechpreviewNetworkingIpv6GetPost**
> void ApplianceTechpreviewNetworkingIpv6GetPost (string contentType, IPv4DetailsRequest body)

IPv6-details

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
    public class ApplianceTechpreviewNetworkingIpv6GetPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewIPv6Api();
            var contentType = contentType_example;  // string | 
            var body = new IPv4DetailsRequest(); // IPv4DetailsRequest | 

            try
            {
                // IPv6-details
                apiInstance.ApplianceTechpreviewNetworkingIpv6GetPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewIPv6Api.ApplianceTechpreviewNetworkingIpv6GetPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**IPv4DetailsRequest**](IPv4DetailsRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewnetworkingipv6post"></a>
# **ApplianceTechpreviewNetworkingIpv6Post**
> void ApplianceTechpreviewNetworkingIpv6Post (string contentType, IPv6SetRequest body)

IPv6-set

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
    public class ApplianceTechpreviewNetworkingIpv6PostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewIPv6Api();
            var contentType = contentType_example;  // string | 
            var body = new IPv6SetRequest(); // IPv6SetRequest | 

            try
            {
                // IPv6-set
                apiInstance.ApplianceTechpreviewNetworkingIpv6Post(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewIPv6Api.ApplianceTechpreviewNetworkingIpv6Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**IPv6SetRequest**](IPv6SetRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

