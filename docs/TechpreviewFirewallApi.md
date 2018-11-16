# IO.Swagger.Api.TechpreviewFirewallApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewNetworkingFirewallAddrInboundDeletePost**](TechpreviewFirewallApi.md#appliancetechpreviewnetworkingfirewalladdrinbounddeletepost) | **POST** /appliance/techpreview/networking/firewall/addr/inbound/delete | Deleterule
[**ApplianceTechpreviewNetworkingFirewallAddrInboundGet**](TechpreviewFirewallApi.md#appliancetechpreviewnetworkingfirewalladdrinboundget) | **GET** /appliance/techpreview/networking/firewall/addr/inbound | Listinboundrules
[**ApplianceTechpreviewNetworkingFirewallAddrInboundPost**](TechpreviewFirewallApi.md#appliancetechpreviewnetworkingfirewalladdrinboundpost) | **POST** /appliance/techpreview/networking/firewall/addr/inbound | Createrule
[**ApplianceTechpreviewNetworkingFirewallAddrInboundPut**](TechpreviewFirewallApi.md#appliancetechpreviewnetworkingfirewalladdrinboundput) | **PUT** /appliance/techpreview/networking/firewall/addr/inbound | Replaceallrules


<a name="appliancetechpreviewnetworkingfirewalladdrinbounddeletepost"></a>
# **ApplianceTechpreviewNetworkingFirewallAddrInboundDeletePost**
> void ApplianceTechpreviewNetworkingFirewallAddrInboundDeletePost (string contentType, DeleteruleRequest body)

Deleterule

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
    public class ApplianceTechpreviewNetworkingFirewallAddrInboundDeletePostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewFirewallApi();
            var contentType = contentType_example;  // string | 
            var body = new DeleteruleRequest(); // DeleteruleRequest | 

            try
            {
                // Deleterule
                apiInstance.ApplianceTechpreviewNetworkingFirewallAddrInboundDeletePost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewFirewallApi.ApplianceTechpreviewNetworkingFirewallAddrInboundDeletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**DeleteruleRequest**](DeleteruleRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewnetworkingfirewalladdrinboundget"></a>
# **ApplianceTechpreviewNetworkingFirewallAddrInboundGet**
> void ApplianceTechpreviewNetworkingFirewallAddrInboundGet (string contentType)

Listinboundrules

Get ordered list of inbound IP addresses that are allowed or denied by firewall.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewNetworkingFirewallAddrInboundGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewFirewallApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Listinboundrules
                apiInstance.ApplianceTechpreviewNetworkingFirewallAddrInboundGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewFirewallApi.ApplianceTechpreviewNetworkingFirewallAddrInboundGet: " + e.Message );
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

<a name="appliancetechpreviewnetworkingfirewalladdrinboundpost"></a>
# **ApplianceTechpreviewNetworkingFirewallAddrInboundPost**
> void ApplianceTechpreviewNetworkingFirewallAddrInboundPost (string contentType, CreateruleRequest body)

Createrule

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
    public class ApplianceTechpreviewNetworkingFirewallAddrInboundPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewFirewallApi();
            var contentType = contentType_example;  // string | 
            var body = new CreateruleRequest(); // CreateruleRequest | 

            try
            {
                // Createrule
                apiInstance.ApplianceTechpreviewNetworkingFirewallAddrInboundPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewFirewallApi.ApplianceTechpreviewNetworkingFirewallAddrInboundPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**CreateruleRequest**](CreateruleRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewnetworkingfirewalladdrinboundput"></a>
# **ApplianceTechpreviewNetworkingFirewallAddrInboundPut**
> void ApplianceTechpreviewNetworkingFirewallAddrInboundPut (string contentType, ReplaceallrulesRequest body)

Replaceallrules

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
    public class ApplianceTechpreviewNetworkingFirewallAddrInboundPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewFirewallApi();
            var contentType = contentType_example;  // string | 
            var body = new ReplaceallrulesRequest(); // ReplaceallrulesRequest | 

            try
            {
                // Replaceallrules
                apiInstance.ApplianceTechpreviewNetworkingFirewallAddrInboundPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewFirewallApi.ApplianceTechpreviewNetworkingFirewallAddrInboundPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ReplaceallrulesRequest**](ReplaceallrulesRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

