# Com.Madana.APIClient.Api.SocialPlatformServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPlatforms**](SocialPlatformServiceApi.md#getplatforms) | **GET** /platforms | Used to Handle Incoming Webhooks from Facebook.
[**ListenTwitterWebhook**](SocialPlatformServiceApi.md#listentwitterwebhook) | **POST** /platforms/twitter | Used to Handle Incoming Webhooks from Facebook.
[**RegisterTwitterWebhook**](SocialPlatformServiceApi.md#registertwitterwebhook) | **GET** /platforms/twitter | Used to Handle Incoming Webhooks from Twitter.



## GetPlatforms

> System.IO.Stream GetPlatforms (string body = null)

Used to Handle Incoming Webhooks from Facebook.

Used to Handle Incoming Webhooks from Facebook

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetPlatformsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new SocialPlatformServiceApi(Configuration.Default);
            var body = body_example;  // string |  (optional) 

            try
            {
                // Used to Handle Incoming Webhooks from Facebook.
                System.IO.Stream result = apiInstance.GetPlatforms(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SocialPlatformServiceApi.GetPlatforms: " + e.Message );
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
| **200** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListenTwitterWebhook

> System.IO.Stream ListenTwitterWebhook (string body = null)

Used to Handle Incoming Webhooks from Facebook.

Used to Handle Incoming Webhooks from Facebook

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class ListenTwitterWebhookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new SocialPlatformServiceApi(Configuration.Default);
            var body = body_example;  // string |  (optional) 

            try
            {
                // Used to Handle Incoming Webhooks from Facebook.
                System.IO.Stream result = apiInstance.ListenTwitterWebhook(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SocialPlatformServiceApi.ListenTwitterWebhook: " + e.Message );
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


## RegisterTwitterWebhook

> System.IO.Stream RegisterTwitterWebhook (string crcToken = null)

Used to Handle Incoming Webhooks from Twitter.

Used to Handle Incoming Webhooks from Twitter

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class RegisterTwitterWebhookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new SocialPlatformServiceApi(Configuration.Default);
            var crcToken = crcToken_example;  // string |  (optional) 

            try
            {
                // Used to Handle Incoming Webhooks from Twitter.
                System.IO.Stream result = apiInstance.RegisterTwitterWebhook(crcToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SocialPlatformServiceApi.RegisterTwitterWebhook: " + e.Message );
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
 **crcToken** | **string**|  | [optional] 

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

