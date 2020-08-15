# Com.MadanaSampleclient.Api.CertificateServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthenticateCertificate**](CertificateServiceApi.md#authenticatecertificate) | **POST** /certificates | Issues certificates for logged-in users.
[**GetCertificate**](CertificateServiceApi.md#getcertificate) | **GET** /certificates/root | 
[**GetCertificate_0**](CertificateServiceApi.md#getcertificate_0) | **GET** /certificates/{fingerprint} | 



## AuthenticateCertificate

> JsonMDNCertificate AuthenticateCertificate (JsonMDNData body = null)

Issues certificates for logged-in users.

Issues certificates for logged-in users

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class AuthenticateCertificateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new CertificateServiceApi(Configuration.Default);
            var body = new JsonMDNData(); // JsonMDNData |  (optional) 

            try
            {
                // Issues certificates for logged-in users.
                JsonMDNCertificate result = apiInstance.AuthenticateCertificate(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CertificateServiceApi.AuthenticateCertificate: " + e.Message );
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
 **body** | [**JsonMDNData**](JsonMDNData.md)|  | [optional] 

### Return type

[**JsonMDNCertificate**](JsonMDNCertificate.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | If the Request have been signed could be verified |  -  |
| **403** | If an error occurs |  -  |
| **500** | If an servsided error occurs |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCertificate

> System.IO.Stream GetCertificate ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class GetCertificateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new CertificateServiceApi(Configuration.Default);

            try
            {
                System.IO.Stream result = apiInstance.GetCertificate();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CertificateServiceApi.GetCertificate: " + e.Message );
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


## GetCertificate_0

> System.IO.Stream GetCertificate_0 (string fingerprint)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class GetCertificate_0Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new CertificateServiceApi(Configuration.Default);
            var fingerprint = fingerprint_example;  // string | 

            try
            {
                System.IO.Stream result = apiInstance.GetCertificate_0(fingerprint);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CertificateServiceApi.GetCertificate_0: " + e.Message );
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
 **fingerprint** | **string**|  | 

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

