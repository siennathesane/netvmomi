# IO.Swagger.Api.TechpreviewSystemupdatesApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewSystemUpdateGet**](TechpreviewSystemupdatesApi.md#appliancetechpreviewsystemupdateget) | **GET** /appliance/techpreview/system/update | System-update
[**ApplianceTechpreviewSystemUpdatePost**](TechpreviewSystemupdatesApi.md#appliancetechpreviewsystemupdatepost) | **POST** /appliance/techpreview/system/update | System-updaterepository


<a name="appliancetechpreviewsystemupdateget"></a>
# **ApplianceTechpreviewSystemUpdateGet**
> void ApplianceTechpreviewSystemUpdateGet (string contentType)

System-update

Get update repository configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewSystemUpdateGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewSystemupdatesApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // System-update
                apiInstance.ApplianceTechpreviewSystemUpdateGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewSystemupdatesApi.ApplianceTechpreviewSystemUpdateGet: " + e.Message );
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

<a name="appliancetechpreviewsystemupdatepost"></a>
# **ApplianceTechpreviewSystemUpdatePost**
> void ApplianceTechpreviewSystemUpdatePost (string contentType, SystemUpdaterepositoryRequest body)

System-updaterepository

Set update repository configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewSystemUpdatePostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewSystemupdatesApi();
            var contentType = contentType_example;  // string | 
            var body = new SystemUpdaterepositoryRequest(); // SystemUpdaterepositoryRequest | 

            try
            {
                // System-updaterepository
                apiInstance.ApplianceTechpreviewSystemUpdatePost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewSystemupdatesApi.ApplianceTechpreviewSystemUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**SystemUpdaterepositoryRequest**](SystemUpdaterepositoryRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

