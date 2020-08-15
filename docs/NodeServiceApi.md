# Com.MadanaSampleclient.Api.NodeServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNodes2**](NodeServiceApi.md#getnodes2) | **GET** /nodes | 
[**PostNodeInfo**](NodeServiceApi.md#postnodeinfo) | **POST** /nodes | 



## GetNodes2

> System.IO.Stream GetNodes2 ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class GetNodes2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new NodeServiceApi(Configuration.Default);

            try
            {
                System.IO.Stream result = apiInstance.GetNodes2();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NodeServiceApi.GetNodes2: " + e.Message );
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


## PostNodeInfo

> System.IO.Stream PostNodeInfo (JsonNodeInfo body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class PostNodeInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new NodeServiceApi(Configuration.Default);
            var body = new JsonNodeInfo(); // JsonNodeInfo |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.PostNodeInfo(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NodeServiceApi.PostNodeInfo: " + e.Message );
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
 **body** | [**JsonNodeInfo**](JsonNodeInfo.md)|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

