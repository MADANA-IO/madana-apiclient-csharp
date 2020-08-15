# Com.MadanaSampleclient.Api.AccountServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateUser**](AccountServiceApi.md#activateuser) | **GET** /account/activation/{token} | 
[**CreateObject**](AccountServiceApi.md#createobject) | **POST** /account/password | Sends an Password reset mail to the given MailAddress.
[**RequestVerificationMail**](AccountServiceApi.md#requestverificationmail) | **GET** /account/verifymail | Used to request a new  activation-mail for the user.
[**UpdateObject**](AccountServiceApi.md#updateobject) | **PUT** /account/password | Receives the Password reset and tries to set the provided password for the user.



## ActivateUser

> System.IO.Stream ActivateUser (string token)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class ActivateUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AccountServiceApi(Configuration.Default);
            var token = token_example;  // string | 

            try
            {
                System.IO.Stream result = apiInstance.ActivateUser(token);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountServiceApi.ActivateUser: " + e.Message );
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
 **token** | **string**|  | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateObject

> System.IO.Stream CreateObject (JsonMDNMailAddress body = null)

Sends an Password reset mail to the given MailAddress.

Sends an Password reset mail to the given MailAddress

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class CreateObjectExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AccountServiceApi(Configuration.Default);
            var body = new JsonMDNMailAddress(); // JsonMDNMailAddress | - the MaiAddress under which the user has signed up (optional) 

            try
            {
                // Sends an Password reset mail to the given MailAddress.
                System.IO.Stream result = apiInstance.CreateObject(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountServiceApi.CreateObject: " + e.Message );
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
 **body** | [**JsonMDNMailAddress**](JsonMDNMailAddress.md)| - the MaiAddress under which the user has signed up | [optional] 

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
| **201** | HTTP Status Accepted if the mail has been send, NOT FOUND if the mail address could be found in the system or EXPECTATION FAILED when an error occured |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RequestVerificationMail

> Dictionary&lt;string, Object&gt; RequestVerificationMail ()

Used to request a new  activation-mail for the user.

Used to request a new  activation-mail for the user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class RequestVerificationMailExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AccountServiceApi(Configuration.Default);

            try
            {
                // Used to request a new  activation-mail for the user.
                Dictionary<string, Object> result = apiInstance.RequestVerificationMail();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountServiceApi.RequestVerificationMail: " + e.Message );
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

**Dictionary<string, Object>**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | If the mail has been sent |  -  |
| **500** | If an servsided error occurs |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateObject

> System.IO.Stream UpdateObject (JsonMDNPasswordReset body = null)

Receives the Password reset and tries to set the provided password for the user.

Receives the Password reset and tries to set the provided password for the user. The Password will only be set if a valid token is provided

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class UpdateObjectExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AccountServiceApi(Configuration.Default);
            var body = new JsonMDNPasswordReset(); // JsonMDNPasswordReset | - the MDN_PasswordReset Object (optional) 

            try
            {
                // Receives the Password reset and tries to set the provided password for the user.
                System.IO.Stream result = apiInstance.UpdateObject(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountServiceApi.UpdateObject: " + e.Message );
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
 **body** | [**JsonMDNPasswordReset**](JsonMDNPasswordReset.md)| - the MDN_PasswordReset Object | [optional] 

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
| **204** | HTTP Status ACCEPTED if password has been reset, FORBIDDEN if the token is invalid, NOT FOUND if the email is invalid, EXPECTATION FAILED if an error occured |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

