# Com.MadanaSampleclient.Api.OrganizationServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNodes3**](OrganizationServiceApi.md#getnodes3) | **GET** /organizations | 



## GetNodes3

> System.IO.Stream GetNodes3 ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class GetNodes3Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new OrganizationServiceApi(Configuration.Default);

            try
            {
                System.IO.Stream result = apiInstance.GetNodes3();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationServiceApi.GetNodes3: " + e.Message );
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

