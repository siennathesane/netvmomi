# IO.Swagger.Api.HealthApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceHealthApplmgmtGet**](HealthApi.md#appliancehealthapplmgmtget) | **GET** /appliance/health/applmgmt | Applianceservices
[**ApplianceHealthDatabaseStorageGet**](HealthApi.md#appliancehealthdatabasestorageget) | **GET** /appliance/health/database-storage | Databasestorage
[**ApplianceHealthLoadGet**](HealthApi.md#appliancehealthloadget) | **GET** /appliance/health/load | Load
[**ApplianceHealthMemGet**](HealthApi.md#appliancehealthmemget) | **GET** /appliance/health/mem | Memory
[**ApplianceHealthSoftwarePackagesGet**](HealthApi.md#appliancehealthsoftwarepackagesget) | **GET** /appliance/health/software-packages | Softwarepackagesupdates
[**ApplianceHealthStorageGet**](HealthApi.md#appliancehealthstorageget) | **GET** /appliance/health/storage | Storage
[**ApplianceHealthSwapGet**](HealthApi.md#appliancehealthswapget) | **GET** /appliance/health/swap | Swap
[**ApplianceHealthSystemGet**](HealthApi.md#appliancehealthsystemget) | **GET** /appliance/health/system | System
[**ApplianceHealthSystemLastcheckGet**](HealthApi.md#appliancehealthsystemlastcheckget) | **GET** /appliance/health/system/lastcheck | Systemlastcheck


<a name="appliancehealthapplmgmtget"></a>
# **ApplianceHealthApplmgmtGet**
> void ApplianceHealthApplmgmtGet (string contentType)

Applianceservices

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
    public class ApplianceHealthApplmgmtGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HealthApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Applianceservices
                apiInstance.ApplianceHealthApplmgmtGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.ApplianceHealthApplmgmtGet: " + e.Message );
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

<a name="appliancehealthdatabasestorageget"></a>
# **ApplianceHealthDatabaseStorageGet**
> void ApplianceHealthDatabaseStorageGet (string contentType)

Databasestorage

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
    public class ApplianceHealthDatabaseStorageGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HealthApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Databasestorage
                apiInstance.ApplianceHealthDatabaseStorageGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.ApplianceHealthDatabaseStorageGet: " + e.Message );
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

<a name="appliancehealthloadget"></a>
# **ApplianceHealthLoadGet**
> void ApplianceHealthLoadGet (string contentType)

Load

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
    public class ApplianceHealthLoadGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HealthApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Load
                apiInstance.ApplianceHealthLoadGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.ApplianceHealthLoadGet: " + e.Message );
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

<a name="appliancehealthmemget"></a>
# **ApplianceHealthMemGet**
> void ApplianceHealthMemGet (string contentType)

Memory

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
    public class ApplianceHealthMemGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HealthApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Memory
                apiInstance.ApplianceHealthMemGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.ApplianceHealthMemGet: " + e.Message );
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

<a name="appliancehealthsoftwarepackagesget"></a>
# **ApplianceHealthSoftwarePackagesGet**
> void ApplianceHealthSoftwarePackagesGet (string contentType)

Softwarepackagesupdates

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
    public class ApplianceHealthSoftwarePackagesGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HealthApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Softwarepackagesupdates
                apiInstance.ApplianceHealthSoftwarePackagesGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.ApplianceHealthSoftwarePackagesGet: " + e.Message );
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

<a name="appliancehealthstorageget"></a>
# **ApplianceHealthStorageGet**
> void ApplianceHealthStorageGet (string contentType)

Storage

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
    public class ApplianceHealthStorageGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HealthApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Storage
                apiInstance.ApplianceHealthStorageGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.ApplianceHealthStorageGet: " + e.Message );
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

<a name="appliancehealthswapget"></a>
# **ApplianceHealthSwapGet**
> void ApplianceHealthSwapGet (string contentType)

Swap

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
    public class ApplianceHealthSwapGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HealthApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Swap
                apiInstance.ApplianceHealthSwapGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.ApplianceHealthSwapGet: " + e.Message );
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

<a name="appliancehealthsystemget"></a>
# **ApplianceHealthSystemGet**
> void ApplianceHealthSystemGet (string contentType)

System

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
    public class ApplianceHealthSystemGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HealthApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // System
                apiInstance.ApplianceHealthSystemGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.ApplianceHealthSystemGet: " + e.Message );
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

<a name="appliancehealthsystemlastcheckget"></a>
# **ApplianceHealthSystemLastcheckGet**
> void ApplianceHealthSystemLastcheckGet (string contentType)

Systemlastcheck

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
    public class ApplianceHealthSystemLastcheckGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HealthApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Systemlastcheck
                apiInstance.ApplianceHealthSystemLastcheckGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.ApplianceHealthSystemLastcheckGet: " + e.Message );
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

