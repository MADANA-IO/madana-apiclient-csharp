# Com.Madana.APIClient.Api.EnclaveServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApproveEnclave**](EnclaveServiceApi.md#approveenclave) | **POST** /enclaves/{uuid}/approval | 
[**AssignEnclaveAgent**](EnclaveServiceApi.md#assignenclaveagent) | **POST** /enclaves/{uuid}/assign | 
[**AttestateEnclave**](EnclaveServiceApi.md#attestateenclave) | **POST** /enclaves/{uuid}/attestation | 
[**CreateEnclaveRunRequest**](EnclaveServiceApi.md#createenclaverunrequest) | **POST** /enclaves | 
[**GetEnclave**](EnclaveServiceApi.md#getenclave) | **GET** /enclaves/{uuid} | 
[**GetEnclaveTypes**](EnclaveServiceApi.md#getenclavetypes) | **GET** /enclaves/types | 
[**GetEnclaves**](EnclaveServiceApi.md#getenclaves) | **GET** /enclaves | Returns UUIDs of existing analyses.
[**KillEnclave**](EnclaveServiceApi.md#killenclave) | **POST** /enclaves/{uuid}/kill | 



## ApproveEnclave

> System.IO.Stream ApproveEnclave (string uuid, JsonEnclaveRunningAttestationApproval body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class ApproveEnclaveExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new EnclaveServiceApi(Configuration.Default);
            var uuid = uuid_example;  // string | 
            var body = new JsonEnclaveRunningAttestationApproval(); // JsonEnclaveRunningAttestationApproval |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.ApproveEnclave(uuid, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnclaveServiceApi.ApproveEnclave: " + e.Message );
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
 **uuid** | **string**|  | 
 **body** | [**JsonEnclaveRunningAttestationApproval**](JsonEnclaveRunningAttestationApproval.md)|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AssignEnclaveAgent

> System.IO.Stream AssignEnclaveAgent (string uuid, JsonNodeInfo body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class AssignEnclaveAgentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new EnclaveServiceApi(Configuration.Default);
            var uuid = uuid_example;  // string | 
            var body = new JsonNodeInfo(); // JsonNodeInfo |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.AssignEnclaveAgent(uuid, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnclaveServiceApi.AssignEnclaveAgent: " + e.Message );
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
 **uuid** | **string**|  | 
 **body** | [**JsonNodeInfo**](JsonNodeInfo.md)|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AttestateEnclave

> System.IO.Stream AttestateEnclave (string uuid, JsonEnclaveRunningAttestation body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class AttestateEnclaveExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new EnclaveServiceApi(Configuration.Default);
            var uuid = uuid_example;  // string | 
            var body = new JsonEnclaveRunningAttestation(); // JsonEnclaveRunningAttestation |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.AttestateEnclave(uuid, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnclaveServiceApi.AttestateEnclave: " + e.Message );
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
 **uuid** | **string**|  | 
 **body** | [**JsonEnclaveRunningAttestation**](JsonEnclaveRunningAttestation.md)|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateEnclaveRunRequest

> System.IO.Stream CreateEnclaveRunRequest (JsonEnclaveRunRequest body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class CreateEnclaveRunRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new EnclaveServiceApi(Configuration.Default);
            var body = new JsonEnclaveRunRequest(); // JsonEnclaveRunRequest |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.CreateEnclaveRunRequest(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnclaveServiceApi.CreateEnclaveRunRequest: " + e.Message );
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
 **body** | [**JsonEnclaveRunRequest**](JsonEnclaveRunRequest.md)|  | [optional] 

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


## GetEnclave

> System.IO.Stream GetEnclave (string uuid)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetEnclaveExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new EnclaveServiceApi(Configuration.Default);
            var uuid = uuid_example;  // string | 

            try
            {
                System.IO.Stream result = apiInstance.GetEnclave(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnclaveServiceApi.GetEnclave: " + e.Message );
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
 **uuid** | **string**|  | 

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


## GetEnclaveTypes

> System.IO.Stream GetEnclaveTypes ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetEnclaveTypesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new EnclaveServiceApi(Configuration.Default);

            try
            {
                System.IO.Stream result = apiInstance.GetEnclaveTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnclaveServiceApi.GetEnclaveTypes: " + e.Message );
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


## GetEnclaves

> System.IO.Stream GetEnclaves (string authorization = null, string created = null, string limit = null, string offset = null, string status = null)

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
    public class GetEnclavesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new EnclaveServiceApi(Configuration.Default);
            var authorization = authorization_example;  // string | Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c (optional) 
            var created = created_example;  // string | - if Queryparam \"created=true\" only the UUIDs of own Requests are shown (optional)  (default to "true")
            var limit = limit_example;  // string | Used for offset pagination. Limit/Offset Paging would look like GET /request?limit=20&offset=100. This query would return the 20 rows starting with the 100th row (optional)  (default to "30")
            var offset = offset_example;  // string | Used for offset pagination. Limit/Offset Paging would look like GET /request?limit=20&offset=100. This query would return the 20 rows starting with the 100th row (optional)  (default to "0")
            var status = status_example;  // string |  (optional) 

            try
            {
                // Returns UUIDs of existing analyses.
                System.IO.Stream result = apiInstance.GetEnclaves(authorization, created, limit, offset, status);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnclaveServiceApi.GetEnclaves: " + e.Message );
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


## KillEnclave

> System.IO.Stream KillEnclave (string uuid)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class KillEnclaveExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new EnclaveServiceApi(Configuration.Default);
            var uuid = uuid_example;  // string | 

            try
            {
                System.IO.Stream result = apiInstance.KillEnclave(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnclaveServiceApi.KillEnclave: " + e.Message );
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
 **uuid** | **string**|  | 

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

