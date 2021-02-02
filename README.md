# Com.Madana.APIClient - the C# library for the madana-api

<h1>Using the madana-api</h1>
       <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available 
       endpoints and used datamodels.   </p>    

 <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p> 
 <br>
  <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>    
  <br>

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.5.0-master.46
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Com.Madana.APIClient.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Model;

namespace Example
{
    public class Example
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

## Documentation for API Endpoints

All URIs are relative to *http://api.madana.io/rest*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountServiceApi* | [**ActivateUser**](docs/AccountServiceApi.md#activateuser) | **GET** /account/activation/{token} | 
*AccountServiceApi* | [**CreatePasswordReset**](docs/AccountServiceApi.md#createpasswordreset) | **POST** /account/password | Sends an Password reset mail to the given MailAddress.
*AccountServiceApi* | [**RequestVerificationMail**](docs/AccountServiceApi.md#requestverificationmail) | **GET** /account/verifymail | Used to request a new  activation-mail for the user.
*AccountServiceApi* | [**UpdatePassword**](docs/AccountServiceApi.md#updatepassword) | **PUT** /account/password | Receives the Password reset and tries to set the provided password for the user.
*AuthenticationServiceApi* | [**AuthenticateApplication**](docs/AuthenticationServiceApi.md#authenticateapplication) | **POST** /authentication/application | Authenticates a new application and returns the token.
*AuthenticationServiceApi* | [**AuthenticateEthereumWallet**](docs/AuthenticationServiceApi.md#authenticateethereumwallet) | **POST** /authentication/ethereum/{wallet} | 
*AuthenticationServiceApi* | [**AuthenticateUser**](docs/AuthenticationServiceApi.md#authenticateuser) | **POST** /authentication | Authenticates a new user and returns the token (  forbidden if the credentials cannot be validated ).
*AuthenticationServiceApi* | [**AuthenticateWithEthereumChallenge**](docs/AuthenticationServiceApi.md#authenticatewithethereumchallenge) | **POST** /authentication/ethereum/{wallet}/challenge | 
*AuthenticationServiceApi* | [**GetFractalAuthenticationURL**](docs/AuthenticationServiceApi.md#getfractalauthenticationurl) | **GET** /authentication/fractal | Returns the AUthorization URL to verify a Twitter Accounts.
*AuthenticationServiceApi* | [**GetNonceForEthereumWallet**](docs/AuthenticationServiceApi.md#getnonceforethereumwallet) | **GET** /authentication/ethereum/{wallet} | Returns a nonce for the client which is used as content for the to be created signature.
*AuthenticationServiceApi* | [**GetObject**](docs/AuthenticationServiceApi.md#getobject) | **GET** /authentication | Used to validate the active connection with the API.
*AuthenticationServiceApi* | [**GetTwitterAuthenticationURL**](docs/AuthenticationServiceApi.md#gettwitterauthenticationurl) | **GET** /authentication/twitter | Returns the AUthorization URL to verify a Twitter Accounts.
*AuthenticationServiceApi* | [**SetFacebookUID**](docs/AuthenticationServiceApi.md#setfacebookuid) | **POST** /authentication/facebook | Used as Callback URL when users have successfully authorized their facbeook account.
*AuthenticationServiceApi* | [**SetFractalUID**](docs/AuthenticationServiceApi.md#setfractaluid) | **POST** /authentication/fractal | 
*AuthenticationServiceApi* | [**SetTwitterUID**](docs/AuthenticationServiceApi.md#settwitteruid) | **POST** /authentication/twitter | 
*CertificateServiceApi* | [**AuthenticateCertificate**](docs/CertificateServiceApi.md#authenticatecertificate) | **POST** /certificates | Issues certificates for logged-in users.
*CertificateServiceApi* | [**GetCertificateByFingerprint**](docs/CertificateServiceApi.md#getcertificatebyfingerprint) | **GET** /certificates/{fingerprint} | 
*CertificateServiceApi* | [**GetRootCertificate**](docs/CertificateServiceApi.md#getrootcertificate) | **GET** /certificates/root | 
*DataCollectionServiceApi* | [**GetMethodsForType**](docs/DataCollectionServiceApi.md#getmethodsfortype) | **GET** /datacollection/types/{name}/methods | 
*DataCollectionServiceApi* | [**GetNodes**](docs/DataCollectionServiceApi.md#getnodes) | **GET** /datacollection/methods | 
*DataCollectionServiceApi* | [**GetTypes**](docs/DataCollectionServiceApi.md#gettypes) | **GET** /datacollection/types | 
*EnclaveServiceApi* | [**AddHistory**](docs/EnclaveServiceApi.md#addhistory) | **POST** /enclaves/{uuid}/history | 
*EnclaveServiceApi* | [**ApproveEnclave**](docs/EnclaveServiceApi.md#approveenclave) | **POST** /enclaves/{uuid}/approval | 
*EnclaveServiceApi* | [**AssignEnclaveAgent**](docs/EnclaveServiceApi.md#assignenclaveagent) | **POST** /enclaves/{uuid}/assign | 
*EnclaveServiceApi* | [**AttestateEnclave**](docs/EnclaveServiceApi.md#attestateenclave) | **POST** /enclaves/{uuid}/attestation | 
*EnclaveServiceApi* | [**CreateEnclaveRunRequest**](docs/EnclaveServiceApi.md#createenclaverunrequest) | **POST** /enclaves | 
*EnclaveServiceApi* | [**GetEnclave**](docs/EnclaveServiceApi.md#getenclave) | **GET** /enclaves/{uuid} | 
*EnclaveServiceApi* | [**GetEnclaveTypes**](docs/EnclaveServiceApi.md#getenclavetypes) | **GET** /enclaves/types | 
*EnclaveServiceApi* | [**GetEnclaves**](docs/EnclaveServiceApi.md#getenclaves) | **GET** /enclaves | Returns UUIDs of existing analyses.
*EnclaveServiceApi* | [**KillEnclave**](docs/EnclaveServiceApi.md#killenclave) | **POST** /enclaves/{uuid}/kill | 
*EnvironmentServiceApi* | [**DeleteEnvironment**](docs/EnvironmentServiceApi.md#deleteenvironment) | **DELETE** /environments/{uuid} | 
*EnvironmentServiceApi* | [**DeleteEnvironmentSubscription**](docs/EnvironmentServiceApi.md#deleteenvironmentsubscription) | **DELETE** /environments/{uuid}/subscribe | 
*EnvironmentServiceApi* | [**GetEnvironment**](docs/EnvironmentServiceApi.md#getenvironment) | **GET** /environments/{uuid} | 
*EnvironmentServiceApi* | [**GetEnvironments**](docs/EnvironmentServiceApi.md#getenvironments) | **GET** /environments | Returns UUIDs of existing analyses.
*EnvironmentServiceApi* | [**GetPublishedEnvironments**](docs/EnvironmentServiceApi.md#getpublishedenvironments) | **GET** /environments/published | 
*EnvironmentServiceApi* | [**GetSubscribedEnvironments**](docs/EnvironmentServiceApi.md#getsubscribedenvironments) | **GET** /environments/subscriptions | 
*EnvironmentServiceApi* | [**PublishEnvironment**](docs/EnvironmentServiceApi.md#publishenvironment) | **POST** /environments | 
*EnvironmentServiceApi* | [**SubscribeEnvironment**](docs/EnvironmentServiceApi.md#subscribeenvironment) | **POST** /environments/{uuid}/subscribe | 
*EnvironmentServiceApi* | [**UpdateEnvironment**](docs/EnvironmentServiceApi.md#updateenvironment) | **PUT** /environments/{uuid} | 
*InvoiceServiceApi* | [**GetBillingPortalURL**](docs/InvoiceServiceApi.md#getbillingportalurl) | **GET** /invoices/portal | 
*InvoiceServiceApi* | [**GetInvoices**](docs/InvoiceServiceApi.md#getinvoices) | **GET** /invoices | 
*NodeServiceApi* | [**GetBootstrap**](docs/NodeServiceApi.md#getbootstrap) | **GET** /nodes/bootstrap | 
*NodeServiceApi* | [**GetNodes2**](docs/NodeServiceApi.md#getnodes2) | **GET** /nodes | 
*NodeServiceApi* | [**PostNodeInfo**](docs/NodeServiceApi.md#postnodeinfo) | **POST** /nodes | 
*OrganizationServiceApi* | [**GetNodes3**](docs/OrganizationServiceApi.md#getnodes3) | **GET** /organizations | 
*RequestServiceApi* | [**AddData**](docs/RequestServiceApi.md#adddata) | **POST** /requests/{uuid}/data | Is used to upload and park the data till the AnalysisRequest gets processed.
*RequestServiceApi* | [**CancelProcessing**](docs/RequestServiceApi.md#cancelprocessing) | **POST** /requests/{uuid}/cancel | Endpoint is called from the Analysis Processing entity to submit the result.
*RequestServiceApi* | [**CreateNewRequest**](docs/RequestServiceApi.md#createnewrequest) | **POST** /requests | Endpoint used to create a new Analysis Request.
*RequestServiceApi* | [**GetActions**](docs/RequestServiceApi.md#getactions) | **GET** /requests/actions | 
*RequestServiceApi* | [**GetAgent**](docs/RequestServiceApi.md#getagent) | **GET** /requests/{uuid}/agent | Is called from the APE to request all parked datasets.
*RequestServiceApi* | [**GetAllRequests**](docs/RequestServiceApi.md#getallrequests) | **GET** /requests | Returns UUIDs of existing analyses.
*RequestServiceApi* | [**GetData**](docs/RequestServiceApi.md#getdata) | **GET** /requests/{uuid}/data | Is called from the APE to request all parked datasets.
*RequestServiceApi* | [**GetRequest**](docs/RequestServiceApi.md#getrequest) | **GET** /requests/{uuid} | Returns the details for certain Request.
*RequestServiceApi* | [**GetResult**](docs/RequestServiceApi.md#getresult) | **GET** /requests/{uuid}/result | Can be called from creator to request the AnalysisResult.
*RequestServiceApi* | [**GetStatus**](docs/RequestServiceApi.md#getstatus) | **GET** /requests/stats | 
*RequestServiceApi* | [**GiveConsent**](docs/RequestServiceApi.md#giveconsent) | **POST** /requests/{uuid}/consent | Used to give consent for request.
*RequestServiceApi* | [**InitRequestParameters**](docs/RequestServiceApi.md#initrequestparameters) | **POST** /requests/{uuid} | Endpoint used initialized addition datacollection parameters for requester.
*RequestServiceApi* | [**SetAgent**](docs/RequestServiceApi.md#setagent) | **POST** /requests/{uuid}/agent | Is called from the APE to request all parked datasets.
*RequestServiceApi* | [**SetResult**](docs/RequestServiceApi.md#setresult) | **POST** /requests/{uuid}/result | Endpoint is called from the Analysis Processing entity to submit the result.
*SocialPlatformServiceApi* | [**GetPlatforms**](docs/SocialPlatformServiceApi.md#getplatforms) | **GET** /platforms | Used to Handle Incoming Webhooks from Facebook.
*SocialPlatformServiceApi* | [**ListenTwitterWebhook**](docs/SocialPlatformServiceApi.md#listentwitterwebhook) | **POST** /platforms/twitter | Used to Handle Incoming Webhooks from Facebook.
*SocialPlatformServiceApi* | [**RegisterTwitterWebhook**](docs/SocialPlatformServiceApi.md#registertwitterwebhook) | **GET** /platforms/twitter | Used to Handle Incoming Webhooks from Twitter.
*SocialServiceApi* | [**GetMyProfile**](docs/SocialServiceApi.md#getmyprofile) | **GET** /social/profiles/me | 
*SocialServiceApi* | [**GetPlatforms2**](docs/SocialServiceApi.md#getplatforms2) | **GET** /social | Returns all Platforms / Systems that can be Connected to the MADANA Service.
*SocialServiceApi* | [**GetRanking**](docs/SocialServiceApi.md#getranking) | **GET** /social/ranking | Returns the Ranking by PTS within the System.
*SocialServiceApi* | [**GetSocialPlatformFeed**](docs/SocialServiceApi.md#getsocialplatformfeed) | **GET** /social/feed/{platform} | 
*SocialServiceApi* | [**GetUserProfile**](docs/SocialServiceApi.md#getuserprofile) | **GET** /social/profiles/{username} | 
*SocialServiceApi* | [**GetUserProfile_0**](docs/SocialServiceApi.md#getuserprofile_0) | **GET** /social/profiles/{username}/simple | 
*SubscriptionServiceApi* | [**AddFreeSubscription**](docs/SubscriptionServiceApi.md#addfreesubscription) | **POST** /subscriptions/saas/free | 
*SubscriptionServiceApi* | [**AddPassTrialSubscription**](docs/SubscriptionServiceApi.md#addpasstrialsubscription) | **POST** /subscriptions/paas/trial | 
*SubscriptionServiceApi* | [**GetApplication**](docs/SubscriptionServiceApi.md#getapplication) | **GET** /subscriptions/active | 
*SubscriptionServiceApi* | [**GetCheckoutSession**](docs/SubscriptionServiceApi.md#getcheckoutsession) | **GET** /subscriptions/{productname}/checkout | 
*SubscriptionServiceApi* | [**GetCheckoutSession2**](docs/SubscriptionServiceApi.md#getcheckoutsession2) | **POST** /subscriptions/{productname}/{newplan} | 
*SystemServiceApi* | [**GetAllObjects**](docs/SystemServiceApi.md#getallobjects) | **GET** /system/health | 
*SystemServiceApi* | [**GetApplication2**](docs/SystemServiceApi.md#getapplication2) | **GET** /system/usage | Return the current application usage.
*UserServiceApi* | [**CancelSubscription**](docs/UserServiceApi.md#cancelsubscription) | **POST** /users/{username}/subscriptions/{planname}/cancel | 
*UserServiceApi* | [**CreateObject**](docs/UserServiceApi.md#createobject) | **POST** /users | Creates a new user object.
*UserServiceApi* | [**DeleteObject**](docs/UserServiceApi.md#deleteobject) | **DELETE** /users/{username} | Deletes an User based on the provided id and securitycontext.
*UserServiceApi* | [**DeleteObject_0**](docs/UserServiceApi.md#deleteobject_0) | **DELETE** /users/{username}/social/{platform}/{ident} | Deletes linked account from the user and securitycontext.
*UserServiceApi* | [**GetAvatars**](docs/UserServiceApi.md#getavatars) | **GET** /users/{username}/avatars | 
*UserServiceApi* | [**GetCertificates**](docs/UserServiceApi.md#getcertificates) | **GET** /users/{username}/certificates | 
*UserServiceApi* | [**GetEnclaveHistory**](docs/UserServiceApi.md#getenclavehistory) | **GET** /users/{username}/enclavehistory | 
*UserServiceApi* | [**GetObject2**](docs/UserServiceApi.md#getobject2) | **GET** /users/{username} | 
*UserServiceApi* | [**SetAvatar**](docs/UserServiceApi.md#setavatar) | **POST** /users/{username}/avatars | 
*UserServiceApi* | [**SetSettings**](docs/UserServiceApi.md#setsettings) | **POST** /users/{username}/settings | 
*UserServiceApi* | [**UpdateObject**](docs/UserServiceApi.md#updateobject) | **PUT** /users/{username} | Updates Userproperties based on the provided user object.


## Documentation for Models

 - [Model.JsonDiskConfig](docs/JsonDiskConfig.md)
 - [Model.JsonEnclavePort](docs/JsonEnclavePort.md)
 - [Model.JsonEnclaveProcess](docs/JsonEnclaveProcess.md)
 - [Model.JsonEnclaveRunRequest](docs/JsonEnclaveRunRequest.md)
 - [Model.JsonEnclaveRunningAttestation](docs/JsonEnclaveRunningAttestation.md)
 - [Model.JsonEnclaveRunningAttestationApproval](docs/JsonEnclaveRunningAttestationApproval.md)
 - [Model.JsonEnclaveRunningAttestationApprovalAllOf](docs/JsonEnclaveRunningAttestationApprovalAllOf.md)
 - [Model.JsonEnvironment](docs/JsonEnvironment.md)
 - [Model.JsonEnvironmentPublishingRequest](docs/JsonEnvironmentPublishingRequest.md)
 - [Model.JsonIPFSSystemInfo](docs/JsonIPFSSystemInfo.md)
 - [Model.JsonKubernetesEnclave](docs/JsonKubernetesEnclave.md)
 - [Model.JsonKubernetesEnclaveAllOf](docs/JsonKubernetesEnclaveAllOf.md)
 - [Model.JsonMDNAUserObject](docs/JsonMDNAUserObject.md)
 - [Model.JsonMDNCertificate](docs/JsonMDNCertificate.md)
 - [Model.JsonMDNData](docs/JsonMDNData.md)
 - [Model.JsonMDNMailAddress](docs/JsonMDNMailAddress.md)
 - [Model.JsonMDNOAuthToken](docs/JsonMDNOAuthToken.md)
 - [Model.JsonMDNPasswordReset](docs/JsonMDNPasswordReset.md)
 - [Model.JsonMDNSetting](docs/JsonMDNSetting.md)
 - [Model.JsonMDNSocialUserObject](docs/JsonMDNSocialUserObject.md)
 - [Model.JsonMDNToken](docs/JsonMDNToken.md)
 - [Model.JsonMDNUser](docs/JsonMDNUser.md)
 - [Model.JsonMDNUserAllOf](docs/JsonMDNUserAllOf.md)
 - [Model.JsonMDNUserCredentials](docs/JsonMDNUserCredentials.md)
 - [Model.JsonMDNUserProfileImage](docs/JsonMDNUserProfileImage.md)
 - [Model.JsonMDNUserSetting](docs/JsonMDNUserSetting.md)
 - [Model.JsonMDNUserSettingAllOf](docs/JsonMDNUserSettingAllOf.md)
 - [Model.JsonNetworkInterface](docs/JsonNetworkInterface.md)
 - [Model.JsonNodeInfo](docs/JsonNodeInfo.md)
 - [Model.JsonProcess](docs/JsonProcess.md)
 - [Model.JsonRunConfig](docs/JsonRunConfig.md)
 - [Model.JsonSGXInfo](docs/JsonSGXInfo.md)
 - [Model.JsonSignedData](docs/JsonSignedData.md)
 - [Model.JsonSignedDataUtils](docs/JsonSignedDataUtils.md)
 - [Model.JsonV1Event](docs/JsonV1Event.md)
 - [Model.JsonV1EventList](docs/JsonV1EventList.md)
 - [Model.JsonV1EventSeries](docs/JsonV1EventSeries.md)
 - [Model.JsonV1EventSource](docs/JsonV1EventSource.md)
 - [Model.JsonV1ListMeta](docs/JsonV1ListMeta.md)
 - [Model.JsonV1ManagedFieldsEntry](docs/JsonV1ManagedFieldsEntry.md)
 - [Model.JsonV1ObjectMeta](docs/JsonV1ObjectMeta.md)
 - [Model.JsonV1ObjectReference](docs/JsonV1ObjectReference.md)
 - [Model.JsonV1OwnerReference](docs/JsonV1OwnerReference.md)
 - [Model.JsonWireguardInterface](docs/JsonWireguardInterface.md)
 - [Model.JsonWireguardInterfaceAllOf](docs/JsonWireguardInterfaceAllOf.md)
 - [Model.XmlNs0DiskConfig](docs/XmlNs0DiskConfig.md)
 - [Model.XmlNs0DiskConfigAllOf](docs/XmlNs0DiskConfigAllOf.md)
 - [Model.XmlNs0EnclavePort](docs/XmlNs0EnclavePort.md)
 - [Model.XmlNs0EnclavePortAllOf](docs/XmlNs0EnclavePortAllOf.md)
 - [Model.XmlNs0EnclaveProcess](docs/XmlNs0EnclaveProcess.md)
 - [Model.XmlNs0EnclaveProcessAllOf](docs/XmlNs0EnclaveProcessAllOf.md)
 - [Model.XmlNs0EnclaveRunningAttestation](docs/XmlNs0EnclaveRunningAttestation.md)
 - [Model.XmlNs0EnclaveRunningAttestationAllOf](docs/XmlNs0EnclaveRunningAttestationAllOf.md)
 - [Model.XmlNs0EnclaveRunningAttestationApproval](docs/XmlNs0EnclaveRunningAttestationApproval.md)
 - [Model.XmlNs0EnclaveRunningAttestationApprovalAllOf](docs/XmlNs0EnclaveRunningAttestationApprovalAllOf.md)
 - [Model.XmlNs0Environment](docs/XmlNs0Environment.md)
 - [Model.XmlNs0EnvironmentAllOf](docs/XmlNs0EnvironmentAllOf.md)
 - [Model.XmlNs0IPFSSystemInfo](docs/XmlNs0IPFSSystemInfo.md)
 - [Model.XmlNs0IPFSSystemInfoAllOf](docs/XmlNs0IPFSSystemInfoAllOf.md)
 - [Model.XmlNs0InputStream](docs/XmlNs0InputStream.md)
 - [Model.XmlNs0KubernetesEnclave](docs/XmlNs0KubernetesEnclave.md)
 - [Model.XmlNs0KubernetesEnclaveAllOf](docs/XmlNs0KubernetesEnclaveAllOf.md)
 - [Model.XmlNs0MDNSetting](docs/XmlNs0MDNSetting.md)
 - [Model.XmlNs0MDNSettingAllOf](docs/XmlNs0MDNSettingAllOf.md)
 - [Model.XmlNs0MDNUserProfileImage](docs/XmlNs0MDNUserProfileImage.md)
 - [Model.XmlNs0MDNUserProfileImageAllOf](docs/XmlNs0MDNUserProfileImageAllOf.md)
 - [Model.XmlNs0MDNUserSetting](docs/XmlNs0MDNUserSetting.md)
 - [Model.XmlNs0MDNUserSettingAllOf](docs/XmlNs0MDNUserSettingAllOf.md)
 - [Model.XmlNs0NetworkInterface](docs/XmlNs0NetworkInterface.md)
 - [Model.XmlNs0NetworkInterfaceAllOf](docs/XmlNs0NetworkInterfaceAllOf.md)
 - [Model.XmlNs0NodeInfo](docs/XmlNs0NodeInfo.md)
 - [Model.XmlNs0NodeInfoAllOf](docs/XmlNs0NodeInfoAllOf.md)
 - [Model.XmlNs0Process](docs/XmlNs0Process.md)
 - [Model.XmlNs0RunConfig](docs/XmlNs0RunConfig.md)
 - [Model.XmlNs0RunConfigAllOf](docs/XmlNs0RunConfigAllOf.md)
 - [Model.XmlNs0SGXInfo](docs/XmlNs0SGXInfo.md)
 - [Model.XmlNs0SGXInfoAllOf](docs/XmlNs0SGXInfoAllOf.md)
 - [Model.XmlNs0SignedData](docs/XmlNs0SignedData.md)
 - [Model.XmlNs0SignedDataAllOf](docs/XmlNs0SignedDataAllOf.md)
 - [Model.XmlNs0WireguardInterface](docs/XmlNs0WireguardInterface.md)
 - [Model.XmlNs0WireguardInterfaceAllOf](docs/XmlNs0WireguardInterfaceAllOf.md)


## Documentation for Authorization

All endpoints do not require authorization.
