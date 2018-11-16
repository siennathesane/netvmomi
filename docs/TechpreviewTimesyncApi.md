# IO.Swagger.Api.TechpreviewTimesyncApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewTimesyncGet**](TechpreviewTimesyncApi.md#appliancetechpreviewtimesyncget) | **GET** /appliance/techpreview/timesync | Timesync
[**ApplianceTechpreviewTimesyncPut**](TechpreviewTimesyncApi.md#appliancetechpreviewtimesyncput) | **PUT** /appliance/techpreview/timesync | Timesync-set


<a name="appliancetechpreviewtimesyncget"></a>
# **ApplianceTechpreviewTimesyncGet**
> void ApplianceTechpreviewTimesyncGet (string contentType)

Timesync

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
    public class ApplianceTechpreviewTimesyncGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewTimesyncApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Timesync
                apiInstance.ApplianceTechpreviewTimesyncGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewTimesyncApi.ApplianceTechpreviewTimesyncGet: " + e.Message );
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

<a name="appliancetechpreviewtimesyncput"></a>
# **ApplianceTechpreviewTimesyncPut**
> void ApplianceTechpreviewTimesyncPut (string contentType, TimesyncSetRequest body)

Timesync-set

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
    public class ApplianceTechpreviewTimesyncPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewTimesyncApi();
            var contentType = contentType_example;  // string | 
            var body = new TimesyncSetRequest(); // TimesyncSetRequest | 

            try
            {
                // Timesync-set
                apiInstance.ApplianceTechpreviewTimesyncPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewTimesyncApi.ApplianceTechpreviewTimesyncPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**TimesyncSetRequest**](TimesyncSetRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

