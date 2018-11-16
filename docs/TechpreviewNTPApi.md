# IO.Swagger.Api.TechpreviewNTPApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewNtpGet**](TechpreviewNTPApi.md#appliancetechpreviewntpget) | **GET** /appliance/techpreview/ntp | Configurationstatus
[**ApplianceTechpreviewNtpServerDeletePost**](TechpreviewNTPApi.md#appliancetechpreviewntpserverdeletepost) | **POST** /appliance/techpreview/ntp/server/delete | NTP-deleteserver
[**ApplianceTechpreviewNtpServerPost**](TechpreviewNTPApi.md#appliancetechpreviewntpserverpost) | **POST** /appliance/techpreview/ntp/server | NTP-addserver
[**ApplianceTechpreviewNtpServerPut**](TechpreviewNTPApi.md#appliancetechpreviewntpserverput) | **PUT** /appliance/techpreview/ntp/server | NTP-setservers
[**ApplianceTechpreviewNtpTestPost**](TechpreviewNTPApi.md#appliancetechpreviewntptestpost) | **POST** /appliance/techpreview/ntp/test | NTP-test


<a name="appliancetechpreviewntpget"></a>
# **ApplianceTechpreviewNtpGet**
> void ApplianceTechpreviewNtpGet (string contentType)

Configurationstatus

Get the NTP configuration status

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewNtpGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewNTPApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Configurationstatus
                apiInstance.ApplianceTechpreviewNtpGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewNTPApi.ApplianceTechpreviewNtpGet: " + e.Message );
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

<a name="appliancetechpreviewntpserverdeletepost"></a>
# **ApplianceTechpreviewNtpServerDeletePost**
> void ApplianceTechpreviewNtpServerDeletePost (string contentType, NTPDeleteserverRequest body)

NTP-deleteserver

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
    public class ApplianceTechpreviewNtpServerDeletePostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewNTPApi();
            var contentType = contentType_example;  // string | 
            var body = new NTPDeleteserverRequest(); // NTPDeleteserverRequest | 

            try
            {
                // NTP-deleteserver
                apiInstance.ApplianceTechpreviewNtpServerDeletePost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewNTPApi.ApplianceTechpreviewNtpServerDeletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**NTPDeleteserverRequest**](NTPDeleteserverRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewntpserverpost"></a>
# **ApplianceTechpreviewNtpServerPost**
> void ApplianceTechpreviewNtpServerPost (string contentType, NTPAddserverRequest body)

NTP-addserver

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
    public class ApplianceTechpreviewNtpServerPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewNTPApi();
            var contentType = contentType_example;  // string | 
            var body = new NTPAddserverRequest(); // NTPAddserverRequest | 

            try
            {
                // NTP-addserver
                apiInstance.ApplianceTechpreviewNtpServerPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewNTPApi.ApplianceTechpreviewNtpServerPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**NTPAddserverRequest**](NTPAddserverRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewntpserverput"></a>
# **ApplianceTechpreviewNtpServerPut**
> void ApplianceTechpreviewNtpServerPut (string contentType, NTPSetserversRequest body)

NTP-setservers

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
    public class ApplianceTechpreviewNtpServerPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewNTPApi();
            var contentType = contentType_example;  // string | 
            var body = new NTPSetserversRequest(); // NTPSetserversRequest | 

            try
            {
                // NTP-setservers
                apiInstance.ApplianceTechpreviewNtpServerPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewNTPApi.ApplianceTechpreviewNtpServerPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**NTPSetserversRequest**](NTPSetserversRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewntptestpost"></a>
# **ApplianceTechpreviewNtpTestPost**
> void ApplianceTechpreviewNtpTestPost (string contentType, NTPTestRequest body)

NTP-test

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
    public class ApplianceTechpreviewNtpTestPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewNTPApi();
            var contentType = contentType_example;  // string | 
            var body = new NTPTestRequest(); // NTPTestRequest | 

            try
            {
                // NTP-test
                apiInstance.ApplianceTechpreviewNtpTestPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewNTPApi.ApplianceTechpreviewNtpTestPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**NTPTestRequest**](NTPTestRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

