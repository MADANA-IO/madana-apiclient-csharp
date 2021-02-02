/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.46
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Model;

namespace Com.Madana.APIClient.Test
{
    /// <summary>
    ///  Class for testing RequestServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RequestServiceApiTests
    {
        private RequestServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RequestServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RequestServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' RequestServiceApi
            //Assert.IsInstanceOf(typeof(RequestServiceApi), instance);
        }

        
        /// <summary>
        /// Test AddData
        /// </summary>
        [Test]
        public void AddDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string authorization = null;
            //JsonSignedDataUtils body = null;
            //var response = instance.AddData(uuid, authorization, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test CancelProcessing
        /// </summary>
        [Test]
        public void CancelProcessingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string authorization = null;
            //JsonSignedDataUtils body = null;
            //var response = instance.CancelProcessing(uuid, authorization, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test CreateNewRequest
        /// </summary>
        [Test]
        public void CreateNewRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //JsonSignedDataUtils body = null;
            //var response = instance.CreateNewRequest(authorization, body);
            //Assert.IsInstanceOf(typeof(string), response, "response is string");
        }
        
        /// <summary>
        /// Test GetActions
        /// </summary>
        [Test]
        public void GetActionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string limit = null;
            //string offset = null;
            //var response = instance.GetActions(limit, offset);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetAgent
        /// </summary>
        [Test]
        public void GetAgentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string authorization = null;
            //var response = instance.GetAgent(uuid, authorization);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetAllRequests
        /// </summary>
        [Test]
        public void GetAllRequestsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string created = null;
            //string history = null;
            //string limit = null;
            //string _new = null;
            //string offset = null;
            //string preview = null;
            //string ready = null;
            //var response = instance.GetAllRequests(authorization, created, history, limit, _new, offset, preview, ready);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetData
        /// </summary>
        [Test]
        public void GetDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string authorization = null;
            //var response = instance.GetData(uuid, authorization);
            //Assert.IsInstanceOf(typeof(JsonSignedDataUtils), response, "response is JsonSignedDataUtils");
        }
        
        /// <summary>
        /// Test GetRequest
        /// </summary>
        [Test]
        public void GetRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string authorization = null;
            //var response = instance.GetRequest(uuid, authorization);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetResult
        /// </summary>
        [Test]
        public void GetResultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string authorization = null;
            //var response = instance.GetResult(uuid, authorization);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetStatus
        /// </summary>
        [Test]
        public void GetStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStatus();
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GiveConsent
        /// </summary>
        [Test]
        public void GiveConsentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string authorization = null;
            //var response = instance.GiveConsent(uuid, authorization);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test InitRequestParameters
        /// </summary>
        [Test]
        public void InitRequestParametersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string authorization = null;
            //string body = null;
            //var response = instance.InitRequestParameters(uuid, authorization, body);
            //Assert.IsInstanceOf(typeof(string), response, "response is string");
        }
        
        /// <summary>
        /// Test SetAgent
        /// </summary>
        [Test]
        public void SetAgentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string authorization = null;
            //var response = instance.SetAgent(uuid, authorization);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test SetResult
        /// </summary>
        [Test]
        public void SetResultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string authorization = null;
            //JsonSignedDataUtils body = null;
            //var response = instance.SetResult(uuid, authorization, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
    }

}
