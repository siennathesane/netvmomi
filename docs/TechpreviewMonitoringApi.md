# IO.Swagger.Api.TechpreviewMonitoringApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceTechpreviewMonitoringSnmpDisablePost**](TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmpdisablepost) | **POST** /appliance/techpreview/monitoring/snmp/disable | DisableSNMP
[**ApplianceTechpreviewMonitoringSnmpEnablePost**](TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmpenablepost) | **POST** /appliance/techpreview/monitoring/snmp/enable | EnableSNMP
[**ApplianceTechpreviewMonitoringSnmpGet**](TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmpget) | **GET** /appliance/techpreview/monitoring/snmp | SNMPconfiguration
[**ApplianceTechpreviewMonitoringSnmpHashPost**](TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmphashpost) | **POST** /appliance/techpreview/monitoring/snmp/hash | Generatehash
[**ApplianceTechpreviewMonitoringSnmpLimitsGet**](TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmplimitsget) | **GET** /appliance/techpreview/monitoring/snmp/limits | GetSNMPlimits
[**ApplianceTechpreviewMonitoringSnmpPost**](TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmppost) | **POST** /appliance/techpreview/monitoring/snmp | SetSNMPconfiguration
[**ApplianceTechpreviewMonitoringSnmpResetPost**](TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmpresetpost) | **POST** /appliance/techpreview/monitoring/snmp/reset | SNMPfactorysettings
[**ApplianceTechpreviewMonitoringSnmpStatsGet**](TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmpstatsget) | **GET** /appliance/techpreview/monitoring/snmp/stats | SNMPStats
[**ApplianceTechpreviewMonitoringSnmpTestPost**](TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmptestpost) | **POST** /appliance/techpreview/monitoring/snmp/test | TestSNMP


<a name="appliancetechpreviewmonitoringsnmpdisablepost"></a>
# **ApplianceTechpreviewMonitoringSnmpDisablePost**
> void ApplianceTechpreviewMonitoringSnmpDisablePost (string contentType)

DisableSNMP

Stop an enabled SNMP agent.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewMonitoringSnmpDisablePostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewMonitoringApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // DisableSNMP
                apiInstance.ApplianceTechpreviewMonitoringSnmpDisablePost(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewMonitoringApi.ApplianceTechpreviewMonitoringSnmpDisablePost: " + e.Message );
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

<a name="appliancetechpreviewmonitoringsnmpenablepost"></a>
# **ApplianceTechpreviewMonitoringSnmpEnablePost**
> void ApplianceTechpreviewMonitoringSnmpEnablePost (string contentType)

EnableSNMP

Start a disabled SNMP agent.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewMonitoringSnmpEnablePostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewMonitoringApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // EnableSNMP
                apiInstance.ApplianceTechpreviewMonitoringSnmpEnablePost(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewMonitoringApi.ApplianceTechpreviewMonitoringSnmpEnablePost: " + e.Message );
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

<a name="appliancetechpreviewmonitoringsnmpget"></a>
# **ApplianceTechpreviewMonitoringSnmpGet**
> void ApplianceTechpreviewMonitoringSnmpGet (string contentType)

SNMPconfiguration

Return an SNMP agent configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewMonitoringSnmpGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewMonitoringApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // SNMPconfiguration
                apiInstance.ApplianceTechpreviewMonitoringSnmpGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewMonitoringApi.ApplianceTechpreviewMonitoringSnmpGet: " + e.Message );
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

<a name="appliancetechpreviewmonitoringsnmphashpost"></a>
# **ApplianceTechpreviewMonitoringSnmpHashPost**
> void ApplianceTechpreviewMonitoringSnmpHashPost (string contentType, GeneratehashRequest body)

Generatehash

Generate localized keys for secure SNMPv3 communications.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewMonitoringSnmpHashPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewMonitoringApi();
            var contentType = contentType_example;  // string | 
            var body = new GeneratehashRequest(); // GeneratehashRequest | 

            try
            {
                // Generatehash
                apiInstance.ApplianceTechpreviewMonitoringSnmpHashPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewMonitoringApi.ApplianceTechpreviewMonitoringSnmpHashPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**GeneratehashRequest**](GeneratehashRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewmonitoringsnmplimitsget"></a>
# **ApplianceTechpreviewMonitoringSnmpLimitsGet**
> void ApplianceTechpreviewMonitoringSnmpLimitsGet (string contentType)

GetSNMPlimits

Get SNMP limits information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewMonitoringSnmpLimitsGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewMonitoringApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // GetSNMPlimits
                apiInstance.ApplianceTechpreviewMonitoringSnmpLimitsGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewMonitoringApi.ApplianceTechpreviewMonitoringSnmpLimitsGet: " + e.Message );
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

<a name="appliancetechpreviewmonitoringsnmppost"></a>
# **ApplianceTechpreviewMonitoringSnmpPost**
> void ApplianceTechpreviewMonitoringSnmpPost (string contentType, SetSNMPconfigurationRequest body)

SetSNMPconfiguration

Set SNMP configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewMonitoringSnmpPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewMonitoringApi();
            var contentType = contentType_example;  // string | 
            var body = new SetSNMPconfigurationRequest(); // SetSNMPconfigurationRequest | 

            try
            {
                // SetSNMPconfiguration
                apiInstance.ApplianceTechpreviewMonitoringSnmpPost(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewMonitoringApi.ApplianceTechpreviewMonitoringSnmpPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [**SetSNMPconfigurationRequest**](SetSNMPconfigurationRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appliancetechpreviewmonitoringsnmpresetpost"></a>
# **ApplianceTechpreviewMonitoringSnmpResetPost**
> void ApplianceTechpreviewMonitoringSnmpResetPost (string contentType)

SNMPfactorysettings

Restore settings to factory defaults.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewMonitoringSnmpResetPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewMonitoringApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // SNMPfactorysettings
                apiInstance.ApplianceTechpreviewMonitoringSnmpResetPost(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewMonitoringApi.ApplianceTechpreviewMonitoringSnmpResetPost: " + e.Message );
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

<a name="appliancetechpreviewmonitoringsnmpstatsget"></a>
# **ApplianceTechpreviewMonitoringSnmpStatsGet**
> void ApplianceTechpreviewMonitoringSnmpStatsGet (string contentType)

SNMPStats

Generate diagnostics report for snmp agent.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewMonitoringSnmpStatsGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewMonitoringApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // SNMPStats
                apiInstance.ApplianceTechpreviewMonitoringSnmpStatsGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewMonitoringApi.ApplianceTechpreviewMonitoringSnmpStatsGet: " + e.Message );
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

<a name="appliancetechpreviewmonitoringsnmptestpost"></a>
# **ApplianceTechpreviewMonitoringSnmpTestPost**
> void ApplianceTechpreviewMonitoringSnmpTestPost (string contentType)

TestSNMP

Send a warmStart notification to all configured traps and inform destinations (see RFC 3418).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplianceTechpreviewMonitoringSnmpTestPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TechpreviewMonitoringApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // TestSNMP
                apiInstance.ApplianceTechpreviewMonitoringSnmpTestPost(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechpreviewMonitoringApi.ApplianceTechpreviewMonitoringSnmpTestPost: " + e.Message );
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

