# IO.Swagger.Api.AuthenticationApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ComVmwareCisSessionDelete**](AuthenticationApi.md#comvmwarecissessiondelete) | **DELETE** /com/vmware/cis/session | Logout
[**ComVmwareCisSessionPost**](AuthenticationApi.md#comvmwarecissessionpost) | **POST** /com/vmware/cis/session | Login


<a name="comvmwarecissessiondelete"></a>
# **ComVmwareCisSessionDelete**
> void ComVmwareCisSessionDelete ()

Logout

Logout of the specified vCenter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ComVmwareCisSessionDeleteExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthenticationApi();

            try
            {
                // Logout
                apiInstance.ComVmwareCisSessionDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.ComVmwareCisSessionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="comvmwarecissessionpost"></a>
# **ComVmwareCisSessionPost**
> void ComVmwareCisSessionPost ()

Login

Login to the specified vCenter and retrieve a session

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ComVmwareCisSessionPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthenticationApi();

            try
            {
                // Login
                apiInstance.ComVmwareCisSessionPost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.ComVmwareCisSessionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

