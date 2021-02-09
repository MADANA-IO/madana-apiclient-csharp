# Com.Madana.APIClient.Api.NodeServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNode**](NodeServiceApi.md#createnode) | **POST** /nodes/v2 | 
[**GetBootstrap**](NodeServiceApi.md#getbootstrap) | **GET** /nodes/bootstrap | 
[**GetNodeV2**](NodeServiceApi.md#getnodev2) | **GET** /nodes/v2/{ident} | 
[**GetNodes2**](NodeServiceApi.md#getnodes2) | **GET** /nodes | 
[**GetNodesV2**](NodeServiceApi.md#getnodesv2) | **GET** /nodes/v2 | Returns UUIDs of existing analyses.
[**KillNode**](NodeServiceApi.md#killnode) | **POST** /nodes/v2/{ident}/kill | 
[**PostNodeInfo**](NodeServiceApi.md#postnodeinfo) | **POST** /nodes | 
[**PostNodeInfo_0**](NodeServiceApi.md#postnodeinfo_0) | **POST** /nodes/create | 



## CreateNode

> System.IO.Stream CreateNode (JsonNodeRunRequest body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class CreateNodeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new NodeServiceApi(Configuration.Default);
            var body = new JsonNodeRunRequest(); // JsonNodeRunRequest |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.CreateNode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NodeServiceApi.CreateNode: " + e.Message );
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
 **body** | [**JsonNodeRunRequest**](JsonNodeRunRequest.md)|  | [optional] 

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


## GetBootstrap

> System.IO.Stream GetBootstrap ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetBootstrapExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new NodeServiceApi(Configuration.Default);

            try
            {
                System.IO.Stream result = apiInstance.GetBootstrap();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NodeServiceApi.GetBootstrap: " + e.Message );
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


## GetNodeV2

> System.IO.Stream GetNodeV2 (string ident)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetNodeV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new NodeServiceApi(Configuration.Default);
            var ident = ident_example;  // string | 

            try
            {
                System.IO.Stream result = apiInstance.GetNodeV2(ident);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NodeServiceApi.GetNodeV2: " + e.Message );
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
 **ident** | **string**|  | 

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


## GetNodes2

> System.IO.Stream GetNodes2 (string owner = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetNodes2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new NodeServiceApi(Configuration.Default);
            var owner = owner_example;  // string |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.GetNodes2(owner);
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


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**|  | [optional] 

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


## GetNodesV2

> System.IO.Stream GetNodesV2 (string authorization = null, string created = null, string limit = null, string offset = null, string status = null)

Returns UUIDs of existing analyses.

Returns UUIDs of existing analyses.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetNodesV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new NodeServiceApi(Configuration.Default);
            var authorization = authorization_example;  // string | Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c (optional) 
            var created = created_example;  // string | - if Queryparam \"created=true\" only the UUIDs of own Requests are shown (optional)  (default to "true")
            var limit = limit_example;  // string | Used for offset pagination. Limit/Offset Paging would look like GET /request?limit=20&offset=100. This query would return the 20 rows starting with the 100th row (optional)  (default to "30")
            var offset = offset_example;  // string | Used for offset pagination. Limit/Offset Paging would look like GET /request?limit=20&offset=100. This query would return the 20 rows starting with the 100th row (optional)  (default to "0")
            var status = status_example;  // string |  (optional) 

            try
            {
                // Returns UUIDs of existing analyses.
                System.IO.Stream result = apiInstance.GetNodesV2(authorization, created, limit, offset, status);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NodeServiceApi.GetNodesV2: " + e.Message );
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
 **authorization** | **string**| Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c | [optional] 
 **created** | **string**| - if Queryparam \&quot;created&#x3D;true\&quot; only the UUIDs of own Requests are shown | [optional] [default to &quot;true&quot;]
 **limit** | **string**| Used for offset pagination. Limit/Offset Paging would look like GET /request?limit&#x3D;20&amp;offset&#x3D;100. This query would return the 20 rows starting with the 100th row | [optional] [default to &quot;30&quot;]
 **offset** | **string**| Used for offset pagination. Limit/Offset Paging would look like GET /request?limit&#x3D;20&amp;offset&#x3D;100. This query would return the 20 rows starting with the 100th row | [optional] [default to &quot;0&quot;]
 **status** | **string**|  | [optional] 

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
| **200** | If the actions could be loaded |  -  |
| **500** | If an servsided error occurs |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## KillNode

> System.IO.Stream KillNode (string ident)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class KillNodeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new NodeServiceApi(Configuration.Default);
            var ident = ident_example;  // string | 

            try
            {
                System.IO.Stream result = apiInstance.KillNode(ident);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NodeServiceApi.KillNode: " + e.Message );
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
 **ident** | **string**|  | 

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
| **201** |  |  -  |

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
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

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


## PostNodeInfo_0

> System.IO.Stream PostNodeInfo_0 (JsonNodeRunRequest body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class PostNodeInfo_0Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new NodeServiceApi(Configuration.Default);
            var body = new JsonNodeRunRequest(); // JsonNodeRunRequest |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.PostNodeInfo_0(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NodeServiceApi.PostNodeInfo_0: " + e.Message );
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
 **body** | [**JsonNodeRunRequest**](JsonNodeRunRequest.md)|  | [optional] 

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

