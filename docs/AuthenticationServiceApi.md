# Com.MadanaSampleclient.Api.AuthenticationServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthenticateApplication**](AuthenticationServiceApi.md#authenticateapplication) | **POST** /authentication/application | Authenticates a new application and returns the token.
[**AuthenticateEthereumWallet**](AuthenticationServiceApi.md#authenticateethereumwallet) | **POST** /authentication/ethereum/{wallet} | 
[**AuthenticateUser**](AuthenticationServiceApi.md#authenticateuser) | **POST** /authentication | Authenticates a new user and returns the token (  forbidden if the credentials cannot be validated ).
[**AuthenticateWithEthereumChallenge**](AuthenticationServiceApi.md#authenticatewithethereumchallenge) | **POST** /authentication/ethereum/{wallet}/challenge | 
[**GetFractalAuthenticationURL**](AuthenticationServiceApi.md#getfractalauthenticationurl) | **GET** /authentication/fractal | Returns the AUthorization URL to verify a Twitter Accounts.
[**GetNonceForEthereumWallet**](AuthenticationServiceApi.md#getnonceforethereumwallet) | **GET** /authentication/ethereum/{wallet} | Returns a nonce for the client which is used as content for the to be created signature.
[**GetObject**](AuthenticationServiceApi.md#getobject) | **GET** /authentication | Used to validate the active connection with the API.
[**GetTwitterAuthenticationURL**](AuthenticationServiceApi.md#gettwitterauthenticationurl) | **GET** /authentication/twitter | Returns the AUthorization URL to verify a Twitter Accounts.
[**SetFacebookUID**](AuthenticationServiceApi.md#setfacebookuid) | **POST** /authentication/facebook | Used as Callback URL when users have successfully authorized their facbeook account.
[**SetFractalUID**](AuthenticationServiceApi.md#setfractaluid) | **POST** /authentication/fractal | 
[**SetTwitterUID**](AuthenticationServiceApi.md#settwitteruid) | **POST** /authentication/twitter | 



## AuthenticateApplication

> JsonMDNToken AuthenticateApplication (JsonMDNCertificate body = null)

Authenticates a new application and returns the token.

Authenticates a new application and returns the token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class AuthenticateApplicationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);
            var body = new JsonMDNCertificate(); // JsonMDNCertificate | the credentials used to validate the user (optional) 

            try
            {
                // Authenticates a new application and returns the token.
                JsonMDNToken result = apiInstance.AuthenticateApplication(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.AuthenticateApplication: " + e.Message );
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
 **body** | [**JsonMDNCertificate**](JsonMDNCertificate.md)| the credentials used to validate the user | [optional] 

### Return type

[**JsonMDNToken**](JsonMDNToken.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | If the application certificate could be verified |  -  |
| **401** | If the application could not be found |  -  |
| **403** | If the an error occurs verifying the Application certificate |  -  |
| **500** | If an servsided error occurs |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AuthenticateEthereumWallet

> System.IO.Stream AuthenticateEthereumWallet (string wallet, JsonMDNOAuthToken body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class AuthenticateEthereumWalletExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);
            var wallet = wallet_example;  // string | the wallet which should be authenticated
            var body = new JsonMDNOAuthToken(); // JsonMDNOAuthToken | Token containing nonce and signate (optional) 

            try
            {
                System.IO.Stream result = apiInstance.AuthenticateEthereumWallet(wallet, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.AuthenticateEthereumWallet: " + e.Message );
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
 **wallet** | **string**| the wallet which should be authenticated | 
 **body** | [**JsonMDNOAuthToken**](JsonMDNOAuthToken.md)| Token containing nonce and signate | [optional] 

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
| **417** | If the nonce could not be verified |  -  |
| **500** | If an servsided error occurs |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AuthenticateUser

> JsonMDNToken AuthenticateUser (JsonMDNUserCredentials body = null)

Authenticates a new user and returns the token (  forbidden if the credentials cannot be validated ).

Authenticates a new user and returns the token (  forbidden if the credentials cannot be validated )

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class AuthenticateUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);
            var body = new JsonMDNUserCredentials(); // JsonMDNUserCredentials | the credentials used to validate the user (optional) 

            try
            {
                // Authenticates a new user and returns the token (  forbidden if the credentials cannot be validated ).
                JsonMDNToken result = apiInstance.AuthenticateUser(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.AuthenticateUser: " + e.Message );
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
 **body** | [**JsonMDNUserCredentials**](JsonMDNUserCredentials.md)| the credentials used to validate the user | [optional] 

### Return type

[**JsonMDNToken**](JsonMDNToken.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | If the credentials could be verified |  -  |
| **403** | If the credentials could not be verified |  -  |
| **500** | If an servsided error occurs |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AuthenticateWithEthereumChallenge

> System.IO.Stream AuthenticateWithEthereumChallenge (string wallet, JsonMDNOAuthToken body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class AuthenticateWithEthereumChallengeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);
            var wallet = wallet_example;  // string | the wallet which should be authenticated
            var body = new JsonMDNOAuthToken(); // JsonMDNOAuthToken | Token containing nonce and signate (optional) 

            try
            {
                System.IO.Stream result = apiInstance.AuthenticateWithEthereumChallenge(wallet, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.AuthenticateWithEthereumChallenge: " + e.Message );
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
 **wallet** | **string**| the wallet which should be authenticated | 
 **body** | [**JsonMDNOAuthToken**](JsonMDNOAuthToken.md)| Token containing nonce and signate | [optional] 

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
| **417** | If the nonce could not be verified |  -  |
| **500** | If an servsided error occurs |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetFractalAuthenticationURL

> System.IO.Stream GetFractalAuthenticationURL ()

Returns the AUthorization URL to verify a Twitter Accounts.

Returns the AUthorization URL to verify a Twitter Accounts

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class GetFractalAuthenticationURLExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);

            try
            {
                // Returns the AUthorization URL to verify a Twitter Accounts.
                System.IO.Stream result = apiInstance.GetFractalAuthenticationURL();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.GetFractalAuthenticationURL: " + e.Message );
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


## GetNonceForEthereumWallet

> JsonMDNToken GetNonceForEthereumWallet (string wallet, string authorization = null)

Returns a nonce for the client which is used as content for the to be created signature.

Returns a nonce for the client which is used as content for the to be created signature

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class GetNonceForEthereumWalletExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);
            var wallet = wallet_example;  // string | - wallet address as String * @HTTP 417 If the address is not valid
            var authorization = authorization_example;  // string | Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c (optional) 

            try
            {
                // Returns a nonce for the client which is used as content for the to be created signature.
                JsonMDNToken result = apiInstance.GetNonceForEthereumWallet(wallet, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.GetNonceForEthereumWallet: " + e.Message );
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
 **wallet** | **string**| - wallet address as String * @HTTP 417 If the address is not valid | 
 **authorization** | **string**| Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c | [optional] 

### Return type

[**JsonMDNToken**](JsonMDNToken.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **500** | If an servsided error occurs |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetObject

> Dictionary&lt;string, Object&gt; GetObject ()

Used to validate the active connection with the API.

Used to validate the active connection with the API

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class GetObjectExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);

            try
            {
                // Used to validate the active connection with the API.
                Dictionary<string, Object> result = apiInstance.GetObject();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.GetObject: " + e.Message );
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
| **200** | If the usage could be generated |  -  |
| **500** | If an servsided error occurs |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTwitterAuthenticationURL

> System.IO.Stream GetTwitterAuthenticationURL ()

Returns the AUthorization URL to verify a Twitter Accounts.

Returns the AUthorization URL to verify a Twitter Accounts

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class GetTwitterAuthenticationURLExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);

            try
            {
                // Returns the AUthorization URL to verify a Twitter Accounts.
                System.IO.Stream result = apiInstance.GetTwitterAuthenticationURL();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.GetTwitterAuthenticationURL: " + e.Message );
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


## SetFacebookUID

> System.IO.Stream SetFacebookUID (string body = null)

Used as Callback URL when users have successfully authorized their facbeook account.

Used as Callback URL when users have successfully authorized their facbeook account

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class SetFacebookUIDExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);
            var body = body_example;  // string |  (optional) 

            try
            {
                // Used as Callback URL when users have successfully authorized their facbeook account.
                System.IO.Stream result = apiInstance.SetFacebookUID(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.SetFacebookUID: " + e.Message );
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
 **body** | **string**|  | [optional] 

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


## SetFractalUID

> System.IO.Stream SetFractalUID (string body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class SetFractalUIDExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);
            var body = body_example;  // string |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.SetFractalUID(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.SetFractalUID: " + e.Message );
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
 **body** | **string**|  | [optional] 

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


## SetTwitterUID

> System.IO.Stream SetTwitterUID (JsonMDNOAuthToken body = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Model;

namespace Example
{
    public class SetTwitterUIDExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new AuthenticationServiceApi(Configuration.Default);
            var body = new JsonMDNOAuthToken(); // JsonMDNOAuthToken |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.SetTwitterUID(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationServiceApi.SetTwitterUID: " + e.Message );
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
 **body** | [**JsonMDNOAuthToken**](JsonMDNOAuthToken.md)|  | [optional] 

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

