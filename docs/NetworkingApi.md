# IO.Swagger.Api.NetworkingApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceNetworkingDnsDomainsGet**](NetworkingApi.md#appliancenetworkingdnsdomainsget) | **GET** /appliance/networking/dns/domains | Domains
[**ApplianceNetworkingDnsDomainsPost**](NetworkingApi.md#appliancenetworkingdnsdomainspost) | **POST** /appliance/networking/dns/domains | Domainsadd
[**ApplianceNetworkingDnsDomainsPut**](NetworkingApi.md#appliancenetworkingdnsdomainsput) | **PUT** /appliance/networking/dns/domains | Domainsset
[**ApplianceNetworkingDnsHostnameGet**](NetworkingApi.md#appliancenetworkingdnshostnameget) | **GET** /appliance/networking/dns/hostname | Hostname
[**ApplianceNetworkingDnsHostnamePut**](NetworkingApi.md#appliancenetworkingdnshostnameput) | **PUT** /appliance/networking/dns/hostname | Hostname-set
[**ApplianceNetworkingDnsHostnameTestPost**](NetworkingApi.md#appliancenetworkingdnshostnametestpost) | **POST** /appliance/networking/dns/hostname/test | Hostname-test
[**ApplianceNetworkingDnsServersGet**](NetworkingApi.md#appliancenetworkingdnsserversget) | **GET** /appliance/networking/dns/servers | DNSservers
[**ApplianceNetworkingDnsServersPost**](NetworkingApi.md#appliancenetworkingdnsserverspost) | **POST** /appliance/networking/dns/servers | DNSservers-add
[**ApplianceNetworkingDnsServersPut**](NetworkingApi.md#appliancenetworkingdnsserversput) | **PUT** /appliance/networking/dns/servers | DNSservers-set
[**ApplianceNetworkingDnsServersTestPost**](NetworkingApi.md#appliancenetworkingdnsserverstestpost) | **POST** /appliance/networking/dns/servers/test | DNSservers-test
[**ApplianceNetworkingInterfacesGet**](NetworkingApi.md#appliancenetworkinginterfacesget) | **GET** /appliance/networking/interfaces | Interfaces
[**ApplianceNetworkingInterfacesNic0Get**](NetworkingApi.md#appliancenetworkinginterfacesnic0get) | **GET** /appliance/networking/interfaces/nic0 | Interface-details


<a name="appliancenetworkingdnsdomainsget"></a>
# **ApplianceNetworkingDnsDomainsGet**
> void ApplianceNetworkingDnsDomainsGet (string contentType)

Domains

DNS search domains

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceNetworkingDnsDomainsGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Domains
                apiInstance.ApplianceNetworkingDnsDomainsGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingDnsDomainsGet: " + e.Message );
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

<a name="appliancenetworkingdnsdomainspost"></a>
# **ApplianceNetworkingDnsDomainsPost**
> void ApplianceNetworkingDnsDomainsPost (string contentType, DomainsaddRequest body)

Domainsadd

DNS search domains

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceNetworkingDnsDomainsPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 
            var body = new DomainsaddRequest(); // DomainsaddRequest | 

            try
            {
                // Domainsadd
                apiInstance.ApplianceNetworkingDnsDomainsPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingDnsDomainsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**DomainsaddRequest**](DomainsaddRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancenetworkingdnsdomainsput"></a>
# **ApplianceNetworkingDnsDomainsPut**
> void ApplianceNetworkingDnsDomainsPut (string contentType, DomainssetRequest body)

Domainsset

DNS search domains

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceNetworkingDnsDomainsPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 
            var body = new DomainssetRequest(); // DomainssetRequest | 

            try
            {
                // Domainsset
                apiInstance.ApplianceNetworkingDnsDomainsPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingDnsDomainsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**DomainssetRequest**](DomainssetRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancenetworkingdnshostnameget"></a>
# **ApplianceNetworkingDnsHostnameGet**
> void ApplianceNetworkingDnsHostnameGet (string contentType)

Hostname

Get the Fully Qualified Doman Name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceNetworkingDnsHostnameGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Hostname
                apiInstance.ApplianceNetworkingDnsHostnameGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingDnsHostnameGet: " + e.Message );
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

<a name="appliancenetworkingdnshostnameput"></a>
# **ApplianceNetworkingDnsHostnamePut**
> void ApplianceNetworkingDnsHostnamePut (string contentType, HostnameSetRequest body)

Hostname-set

Set the Fully Qualified Domain Name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceNetworkingDnsHostnamePutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 
            var body = new HostnameSetRequest(); // HostnameSetRequest | 

            try
            {
                // Hostname-set
                apiInstance.ApplianceNetworkingDnsHostnamePut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingDnsHostnamePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**HostnameSetRequest**](HostnameSetRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancenetworkingdnshostnametestpost"></a>
# **ApplianceNetworkingDnsHostnameTestPost**
> void ApplianceNetworkingDnsHostnameTestPost (string contentType, HostnameTestRequest body)

Hostname-test

Test the Fully Qualified Domain Name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceNetworkingDnsHostnameTestPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 
            var body = new HostnameTestRequest(); // HostnameTestRequest | 

            try
            {
                // Hostname-test
                apiInstance.ApplianceNetworkingDnsHostnameTestPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingDnsHostnameTestPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**HostnameTestRequest**](HostnameTestRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancenetworkingdnsserversget"></a>
# **ApplianceNetworkingDnsServersGet**
> void ApplianceNetworkingDnsServersGet (string contentType)

DNSservers

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
    public class ApplianceNetworkingDnsServersGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // DNSservers
                apiInstance.ApplianceNetworkingDnsServersGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingDnsServersGet: " + e.Message );
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

<a name="appliancenetworkingdnsserverspost"></a>
# **ApplianceNetworkingDnsServersPost**
> void ApplianceNetworkingDnsServersPost (string contentType, DNSserversAddRequest body)

DNSservers-add

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
    public class ApplianceNetworkingDnsServersPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 
            var body = new DNSserversAddRequest(); // DNSserversAddRequest | 

            try
            {
                // DNSservers-add
                apiInstance.ApplianceNetworkingDnsServersPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingDnsServersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**DNSserversAddRequest**](DNSserversAddRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancenetworkingdnsserversput"></a>
# **ApplianceNetworkingDnsServersPut**
> void ApplianceNetworkingDnsServersPut (string contentType, DNSserversSetRequest body)

DNSservers-set

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
    public class ApplianceNetworkingDnsServersPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 
            var body = new DNSserversSetRequest(); // DNSserversSetRequest | 

            try
            {
                // DNSservers-set
                apiInstance.ApplianceNetworkingDnsServersPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingDnsServersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**DNSserversSetRequest**](DNSserversSetRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancenetworkingdnsserverstestpost"></a>
# **ApplianceNetworkingDnsServersTestPost**
> void ApplianceNetworkingDnsServersTestPost (string contentType, DNSserversTestRequest body)

DNSservers-test

Test if dns servers are reachable.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceNetworkingDnsServersTestPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 
            var body = new DNSserversTestRequest(); // DNSserversTestRequest | 

            try
            {
                // DNSservers-test
                apiInstance.ApplianceNetworkingDnsServersTestPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingDnsServersTestPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**DNSserversTestRequest**](DNSserversTestRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancenetworkinginterfacesget"></a>
# **ApplianceNetworkingInterfacesGet**
> void ApplianceNetworkingInterfacesGet (string contentType)

Interfaces

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
    public class ApplianceNetworkingInterfacesGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Interfaces
                apiInstance.ApplianceNetworkingInterfacesGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingInterfacesGet: " + e.Message );
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

<a name="appliancenetworkinginterfacesnic0get"></a>
# **ApplianceNetworkingInterfacesNic0Get**
> void ApplianceNetworkingInterfacesNic0Get (string contentType)

Interface-details

Get information about a particular network interface.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceNetworkingInterfacesNic0GetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NetworkingApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Interface-details
                apiInstance.ApplianceNetworkingInterfacesNic0Get(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkingApi.ApplianceNetworkingInterfacesNic0Get: " + e.Message );
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

