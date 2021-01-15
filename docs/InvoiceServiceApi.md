# Com.Madana.APIClient.Api.InvoiceServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBillingPortalURL**](InvoiceServiceApi.md#getbillingportalurl) | **GET** /invoices/portal | 
[**GetInvoices**](InvoiceServiceApi.md#getinvoices) | **GET** /invoices | 



## GetBillingPortalURL

> System.IO.Stream GetBillingPortalURL ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetBillingPortalURLExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new InvoiceServiceApi(Configuration.Default);

            try
            {
                System.IO.Stream result = apiInstance.GetBillingPortalURL();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoiceServiceApi.GetBillingPortalURL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInvoices

> System.IO.Stream GetInvoices (string dayssince = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new InvoiceServiceApi(Configuration.Default);
            var dayssince = dayssince_example;  // string |  (optional)  (default to "366")

            try
            {
                System.IO.Stream result = apiInstance.GetInvoices(dayssince);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoiceServiceApi.GetInvoices: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dayssince** | **string**|  | [optional] [default to &quot;366&quot;]

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

