# IO.Swagger.Api.TechpreviewLocalaccountsApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet**](TechpreviewLocalaccountsApi.md#appliancetechpreviewlocalaccountsuserbyappliancelocaluserget) | **GET** /appliance/techpreview/local-accounts/user/{appliance_local_user} | Localaccounts-details
[**ApplianceTechpreviewLocalAccountsUserGet**](TechpreviewLocalaccountsApi.md#appliancetechpreviewlocalaccountsuserget) | **GET** /appliance/techpreview/local-accounts/user | Localaccounts
[**ApplianceTechpreviewLocalAccountsUserPost**](TechpreviewLocalaccountsApi.md#appliancetechpreviewlocalaccountsuserpost) | **POST** /appliance/techpreview/local-accounts/user | Localaccounts-create
[**ApplianceTechpreviewLocalAccountsUserPut**](TechpreviewLocalaccountsApi.md#appliancetechpreviewlocalaccountsuserput) | **PUT** /appliance/techpreview/local-accounts/user | Localaccounts-update
[**ApplianceTechpreviewLocalAccountsUserTestDelete**](TechpreviewLocalaccountsApi.md#appliancetechpreviewlocalaccountsusertestdelete) | **DELETE** /appliance/techpreview/local-accounts/user/test | Localaccounts-remove


<a name="appliancetechpreviewlocalaccountsuserbyappliancelocaluserget"></a>
# **ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet**
> void ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet (string contentType, string applianceLocalUser)

Localaccounts-details

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
    public class ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewLocalaccountsApi();
            var contentType = contentType_example;  // string | 
            var applianceLocalUser = applianceLocalUser_example;  // string | 

            try
            {
                // Localaccounts-details
                apiInstance.ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet(contentType, applianceLocalUser);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewLocalaccountsApi.ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **applianceLocalUser** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewlocalaccountsuserget"></a>
# **ApplianceTechpreviewLocalAccountsUserGet**
> void ApplianceTechpreviewLocalAccountsUserGet (string contentType)

Localaccounts

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
    public class ApplianceTechpreviewLocalAccountsUserGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewLocalaccountsApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Localaccounts
                apiInstance.ApplianceTechpreviewLocalAccountsUserGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewLocalaccountsApi.ApplianceTechpreviewLocalAccountsUserGet: " + e.Message );
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

<a name="appliancetechpreviewlocalaccountsuserpost"></a>
# **ApplianceTechpreviewLocalAccountsUserPost**
> void ApplianceTechpreviewLocalAccountsUserPost (string contentType, LocalaccountsCreateRequest body)

Localaccounts-create

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
    public class ApplianceTechpreviewLocalAccountsUserPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewLocalaccountsApi();
            var contentType = contentType_example;  // string | 
            var body = new LocalaccountsCreateRequest(); // LocalaccountsCreateRequest | 

            try
            {
                // Localaccounts-create
                apiInstance.ApplianceTechpreviewLocalAccountsUserPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewLocalaccountsApi.ApplianceTechpreviewLocalAccountsUserPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**LocalaccountsCreateRequest**](LocalaccountsCreateRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewlocalaccountsuserput"></a>
# **ApplianceTechpreviewLocalAccountsUserPut**
> void ApplianceTechpreviewLocalAccountsUserPut (string contentType, LocalaccountsUpdateRequest body)

Localaccounts-update

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
    public class ApplianceTechpreviewLocalAccountsUserPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewLocalaccountsApi();
            var contentType = contentType_example;  // string | 
            var body = new LocalaccountsUpdateRequest(); // LocalaccountsUpdateRequest | 

            try
            {
                // Localaccounts-update
                apiInstance.ApplianceTechpreviewLocalAccountsUserPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewLocalaccountsApi.ApplianceTechpreviewLocalAccountsUserPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**LocalaccountsUpdateRequest**](LocalaccountsUpdateRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewlocalaccountsusertestdelete"></a>
# **ApplianceTechpreviewLocalAccountsUserTestDelete**
> void ApplianceTechpreviewLocalAccountsUserTestDelete (string contentType)

Localaccounts-remove

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
    public class ApplianceTechpreviewLocalAccountsUserTestDeleteExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewLocalaccountsApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Localaccounts-remove
                apiInstance.ApplianceTechpreviewLocalAccountsUserTestDelete(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewLocalaccountsApi.ApplianceTechpreviewLocalAccountsUserTestDelete: " + e.Message );
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

