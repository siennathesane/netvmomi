# IO.Swagger.Api.AccessApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceAccessConsolecliGet**](AccessApi.md#applianceaccessconsolecliget) | **GET** /appliance/access/consolecli | ConsoleCLI
[**ApplianceAccessConsolecliPut**](AccessApi.md#applianceaccessconsolecliput) | **PUT** /appliance/access/consolecli | ConsoleCLI-disable
[**ApplianceAccessDcuiGet**](AccessApi.md#applianceaccessdcuiget) | **GET** /appliance/access/dcui | DCUI
[**ApplianceAccessDcuiPut**](AccessApi.md#applianceaccessdcuiput) | **PUT** /appliance/access/dcui | DCUI-disable
[**ApplianceAccessShellGet**](AccessApi.md#applianceaccessshellget) | **GET** /appliance/access/shell | Shell
[**ApplianceAccessShellPut**](AccessApi.md#applianceaccessshellput) | **PUT** /appliance/access/shell | Shell-disable
[**ApplianceAccessSshGet**](AccessApi.md#applianceaccesssshget) | **GET** /appliance/access/ssh | SSH
[**ApplianceAccessSshPut**](AccessApi.md#applianceaccesssshput) | **PUT** /appliance/access/ssh | SSH-disable


<a name="applianceaccessconsolecliget"></a>
# **ApplianceAccessConsolecliGet**
> void ApplianceAccessConsolecliGet (string contentType)

ConsoleCLI

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
    public class ApplianceAccessConsolecliGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccessApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // ConsoleCLI
                apiInstance.ApplianceAccessConsolecliGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.ApplianceAccessConsolecliGet: " + e.Message );
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

<a name="applianceaccessconsolecliput"></a>
# **ApplianceAccessConsolecliPut**
> void ApplianceAccessConsolecliPut (string contentType, ConsoleCLIDisableRequest body)

ConsoleCLI-disable

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
    public class ApplianceAccessConsolecliPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccessApi();
            var contentType = contentType_example;  // string | 
            var body = new ConsoleCLIDisableRequest(); // ConsoleCLIDisableRequest | 

            try
            {
                // ConsoleCLI-disable
                apiInstance.ApplianceAccessConsolecliPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.ApplianceAccessConsolecliPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ConsoleCLIDisableRequest**](ConsoleCLIDisableRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applianceaccessdcuiget"></a>
# **ApplianceAccessDcuiGet**
> void ApplianceAccessDcuiGet (string contentType)

DCUI

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
    public class ApplianceAccessDcuiGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccessApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // DCUI
                apiInstance.ApplianceAccessDcuiGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.ApplianceAccessDcuiGet: " + e.Message );
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

<a name="applianceaccessdcuiput"></a>
# **ApplianceAccessDcuiPut**
> void ApplianceAccessDcuiPut (string contentType, DCUIDisableRequest body)

DCUI-disable

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
    public class ApplianceAccessDcuiPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccessApi();
            var contentType = contentType_example;  // string | 
            var body = new DCUIDisableRequest(); // DCUIDisableRequest | 

            try
            {
                // DCUI-disable
                apiInstance.ApplianceAccessDcuiPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.ApplianceAccessDcuiPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**DCUIDisableRequest**](DCUIDisableRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applianceaccessshellget"></a>
# **ApplianceAccessShellGet**
> void ApplianceAccessShellGet (string contentType)

Shell

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
    public class ApplianceAccessShellGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccessApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Shell
                apiInstance.ApplianceAccessShellGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.ApplianceAccessShellGet: " + e.Message );
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

<a name="applianceaccessshellput"></a>
# **ApplianceAccessShellPut**
> void ApplianceAccessShellPut (string contentType, ShellDisableRequest body)

Shell-disable

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
    public class ApplianceAccessShellPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccessApi();
            var contentType = contentType_example;  // string | 
            var body = new ShellDisableRequest(); // ShellDisableRequest | 

            try
            {
                // Shell-disable
                apiInstance.ApplianceAccessShellPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.ApplianceAccessShellPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**ShellDisableRequest**](ShellDisableRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applianceaccesssshget"></a>
# **ApplianceAccessSshGet**
> void ApplianceAccessSshGet (string contentType)

SSH

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
    public class ApplianceAccessSshGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccessApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // SSH
                apiInstance.ApplianceAccessSshGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.ApplianceAccessSshGet: " + e.Message );
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

<a name="applianceaccesssshput"></a>
# **ApplianceAccessSshPut**
> void ApplianceAccessSshPut (string contentType, SSHDisableRequest body)

SSH-disable

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
    public class ApplianceAccessSshPutExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccessApi();
            var contentType = contentType_example;  // string | 
            var body = new SSHDisableRequest(); // SSHDisableRequest | 

            try
            {
                // SSH-disable
                apiInstance.ApplianceAccessSshPut(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.ApplianceAccessSshPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**SSHDisableRequest**](SSHDisableRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

