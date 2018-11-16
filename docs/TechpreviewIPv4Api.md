# IO.Swagger.Api.TechpreviewIPv4Api

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewNetworkingIpv4Get**](TechpreviewIPv4Api.md#appliancetechpreviewnetworkingipv4get) | **GET** /appliance/techpreview/networking/ipv4 | IPv4
[**ApplianceTechpreviewNetworkingIpv4GetPost**](TechpreviewIPv4Api.md#appliancetechpreviewnetworkingipv4getpost) | **POST** /appliance/techpreview/networking/ipv4/get | IPv4-details
[**ApplianceTechpreviewNetworkingIpv4Post**](TechpreviewIPv4Api.md#appliancetechpreviewnetworkingipv4post) | **POST** /appliance/techpreview/networking/ipv4 | IPv4-set
[**ApplianceTechpreviewNetworkingIpv4RenewPost**](TechpreviewIPv4Api.md#appliancetechpreviewnetworkingipv4renewpost) | **POST** /appliance/techpreview/networking/ipv4/renew | IPv4-renew


<a name="appliancetechpreviewnetworkingipv4get"></a>
# **ApplianceTechpreviewNetworkingIpv4Get**
> void ApplianceTechpreviewNetworkingIpv4Get (string contentType)

IPv4

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
    public class ApplianceTechpreviewNetworkingIpv4GetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewIPv4Api();
            var contentType = contentType_example;  // string | 

            try
            {
                // IPv4
                apiInstance.ApplianceTechpreviewNetworkingIpv4Get(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewIPv4Api.ApplianceTechpreviewNetworkingIpv4Get: " + e.Message );
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

<a name="appliancetechpreviewnetworkingipv4getpost"></a>
# **ApplianceTechpreviewNetworkingIpv4GetPost**
> void ApplianceTechpreviewNetworkingIpv4GetPost (string contentType, IPv4DetailsRequest body)

IPv4-details

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
    public class ApplianceTechpreviewNetworkingIpv4GetPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewIPv4Api();
            var contentType = contentType_example;  // string | 
            var body = new IPv4DetailsRequest(); // IPv4DetailsRequest | 

            try
            {
                // IPv4-details
                apiInstance.ApplianceTechpreviewNetworkingIpv4GetPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewIPv4Api.ApplianceTechpreviewNetworkingIpv4GetPost: " + e.Message );
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

<a name="appliancetechpreviewnetworkingipv4post"></a>
# **ApplianceTechpreviewNetworkingIpv4Post**
> void ApplianceTechpreviewNetworkingIpv4Post (string contentType, IPv4SetRequest body)

IPv4-set

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
    public class ApplianceTechpreviewNetworkingIpv4PostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewIPv4Api();
            var contentType = contentType_example;  // string | 
            var body = new IPv4SetRequest(); // IPv4SetRequest | 

            try
            {
                // IPv4-set
                apiInstance.ApplianceTechpreviewNetworkingIpv4Post(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewIPv4Api.ApplianceTechpreviewNetworkingIpv4Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**IPv4SetRequest**](IPv4SetRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewnetworkingipv4renewpost"></a>
# **ApplianceTechpreviewNetworkingIpv4RenewPost**
> void ApplianceTechpreviewNetworkingIpv4RenewPost (string contentType, IPv4DetailsRequest body)

IPv4-renew

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
    public class ApplianceTechpreviewNetworkingIpv4RenewPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewIPv4Api();
            var contentType = contentType_example;  // string | 
            var body = new IPv4DetailsRequest(); // IPv4DetailsRequest | 

            try
            {
                // IPv4-renew
                apiInstance.ApplianceTechpreviewNetworkingIpv4RenewPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewIPv4Api.ApplianceTechpreviewNetworkingIpv4RenewPost: " + e.Message );
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

