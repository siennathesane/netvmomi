# IO.Swagger.Api.MonitoringApi

All URIs are relative to *http://example.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplianceMonitoringGet**](MonitoringApi.md#appliancemonitoringget) | **GET** /appliance/monitoring | List
[**ApplianceMonitoringNetRxActivityEth0Get**](MonitoringApi.md#appliancemonitoringnetrxactivityeth0get) | **GET** /appliance/monitoring/net.rx.activity.eth0 | Detailsfor:netRXeth0
[**ApplianceMonitoringQueryGet**](MonitoringApi.md#appliancemonitoringqueryget) | **GET** /appliance/monitoring/query | Querystatsfor:neteth0


<a name="appliancemonitoringget"></a>
# **ApplianceMonitoringGet**
> void ApplianceMonitoringGet (string contentType)

List

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
    public class ApplianceMonitoringGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MonitoringApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // List
                apiInstance.ApplianceMonitoringGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.ApplianceMonitoringGet: " + e.Message );
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

<a name="appliancemonitoringnetrxactivityeth0get"></a>
# **ApplianceMonitoringNetRxActivityEth0Get**
> void ApplianceMonitoringNetRxActivityEth0Get (string contentType)

Detailsfor:netRXeth0

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
    public class ApplianceMonitoringNetRxActivityEth0GetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MonitoringApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Detailsfor:netRXeth0
                apiInstance.ApplianceMonitoringNetRxActivityEth0Get(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.ApplianceMonitoringNetRxActivityEth0Get: " + e.Message );
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

<a name="appliancemonitoringqueryget"></a>
# **ApplianceMonitoringQueryGet**
> void ApplianceMonitoringQueryGet (string itemInterval, DateTime? itemEndTime, string itemNames1, string itemNames2, DateTime? itemStartTime, string itemFunction, string contentType)

Querystatsfor:neteth0

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
    public class ApplianceMonitoringQueryGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MonitoringApi();
            var itemInterval = itemInterval_example;  // string | 
            var itemEndTime = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var itemNames1 = itemNames1_example;  // string | 
            var itemNames2 = itemNames2_example;  // string | 
            var itemStartTime = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var itemFunction = itemFunction_example;  // string | 
            var contentType = contentType_example;  // string | 

            try
            {
                // Querystatsfor:neteth0
                apiInstance.ApplianceMonitoringQueryGet(itemInterval, itemEndTime, itemNames1, itemNames2, itemStartTime, itemFunction, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.ApplianceMonitoringQueryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemInterval** | **string**|  | 
 **itemEndTime** | **DateTime?**|  | 
 **itemNames1** | **string**|  | 
 **itemNames2** | **string**|  | 
 **itemStartTime** | **DateTime?**|  | 
 **itemFunction** | **string**|  | 
 **contentType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

