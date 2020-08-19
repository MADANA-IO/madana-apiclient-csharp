# Com.Madana.APIClient.Api.CertificateServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthenticateCertificate**](CertificateServiceApi.md#authenticatecertificate) | **POST** /certificates | Issues certificates for logged-in users.
[**GetCertificateByFingerprint**](CertificateServiceApi.md#getcertificatebyfingerprint) | **GET** /certificates/{fingerprint} | 
[**GetRootCertificate**](CertificateServiceApi.md#getrootcertificate) | **GET** /certificates/root | 



## AuthenticateCertificate

> JsonMDNCertificate AuthenticateCertificate (JsonMDNData body = null)

Issues certificates for logged-in users.

Issues certificates for logged-in users

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

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


## GetCertificateByFingerprint

> System.IO.Stream GetCertificateByFingerprint (string fingerprint)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetCertificateByFingerprintExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new CertificateServiceApi(Configuration.Default);
            var fingerprint = fingerprint_example;  // string | 

            try
            {
                System.IO.Stream result = apiInstance.GetCertificateByFingerprint(fingerprint);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CertificateServiceApi.GetCertificateByFingerprint: " + e.Message );
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


## GetRootCertificate

> System.IO.Stream GetRootCertificate ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetRootCertificateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new CertificateServiceApi(Configuration.Default);

            try
            {
                System.IO.Stream result = apiInstance.GetRootCertificate();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CertificateServiceApi.GetRootCertificate: " + e.Message );
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

