# Com.Madana.APIClient.Api.SocialServiceApi

All URIs are relative to *http://api.madana.io/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMyProfile**](SocialServiceApi.md#getmyprofile) | **GET** /social/profiles/me | 
[**GetPlatforms2**](SocialServiceApi.md#getplatforms2) | **GET** /social | Returns all Platforms / Systems that can be Connected to the MADANA Service.
[**GetRanking**](SocialServiceApi.md#getranking) | **GET** /social/ranking | Returns the Ranking by PTS within the System.
[**GetSocialPlatformFeed**](SocialServiceApi.md#getsocialplatformfeed) | **GET** /social/feed/{platform} | 
[**GetUserProfile**](SocialServiceApi.md#getuserprofile) | **GET** /social/profiles/{username} | 
[**GetUserProfile_0**](SocialServiceApi.md#getuserprofile_0) | **GET** /social/profiles/{username}/simple | 



## GetMyProfile

> System.IO.Stream GetMyProfile ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetMyProfileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new SocialServiceApi(Configuration.Default);

            try
            {
                System.IO.Stream result = apiInstance.GetMyProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SocialServiceApi.GetMyProfile: " + e.Message );
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


## GetPlatforms2

> System.IO.Stream GetPlatforms2 ()

Returns all Platforms / Systems that can be Connected to the MADANA Service.

Returns all Platforms / Systems that can be Connected to the MADANA Service

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetPlatforms2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new SocialServiceApi(Configuration.Default);

            try
            {
                // Returns all Platforms / Systems that can be Connected to the MADANA Service.
                System.IO.Stream result = apiInstance.GetPlatforms2();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SocialServiceApi.GetPlatforms2: " + e.Message );
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
| **200** | List&lt;{MDN_SocialPlatform&gt; |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRanking

> System.IO.Stream GetRanking (string limit = null, string offset = null)

Returns the Ranking by PTS within the System.

Returns the Ranking by PTS within the System

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetRankingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new SocialServiceApi(Configuration.Default);
            var limit = limit_example;  // string |  (optional)  (default to "99")
            var offset = offset_example;  // string |  (optional)  (default to "0")

            try
            {
                // Returns the Ranking by PTS within the System.
                System.IO.Stream result = apiInstance.GetRanking(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SocialServiceApi.GetRanking: " + e.Message );
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
 **limit** | **string**|  | [optional] [default to &quot;99&quot;]
 **offset** | **string**|  | [optional] [default to &quot;0&quot;]

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
| **200** | Map&lt;String, String&gt; - The key is the username and the value are the points |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSocialPlatformFeed

> System.IO.Stream GetSocialPlatformFeed (string platform)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetSocialPlatformFeedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new SocialServiceApi(Configuration.Default);
            var platform = platform_example;  // string | 

            try
            {
                System.IO.Stream result = apiInstance.GetSocialPlatformFeed(platform);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SocialServiceApi.GetSocialPlatformFeed: " + e.Message );
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
 **platform** | **string**|  | 

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


## GetUserProfile

> System.IO.Stream GetUserProfile (string username, string simple = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetUserProfileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new SocialServiceApi(Configuration.Default);
            var username = username_example;  // string | 
            var simple = simple_example;  // string |  (optional)  (default to "false")

            try
            {
                System.IO.Stream result = apiInstance.GetUserProfile(username, simple);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SocialServiceApi.GetUserProfile: " + e.Message );
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
 **username** | **string**|  | 
 **simple** | **string**|  | [optional] [default to &quot;false&quot;]

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


## GetUserProfile_0

> System.IO.Stream GetUserProfile_0 (string username)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class GetUserProfile_0Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://api.madana.io/rest";
            var apiInstance = new SocialServiceApi(Configuration.Default);
            var username = username_example;  // string | 

            try
            {
                System.IO.Stream result = apiInstance.GetUserProfile_0(username);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SocialServiceApi.GetUserProfile_0: " + e.Message );
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
 **username** | **string**|  | 

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

