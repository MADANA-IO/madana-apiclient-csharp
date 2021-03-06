/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.56
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
    ///  Class for testing EnvironmentServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EnvironmentServiceApiTests
    {
        private EnvironmentServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EnvironmentServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EnvironmentServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' EnvironmentServiceApi
            //Assert.IsInstanceOf(typeof(EnvironmentServiceApi), instance);
        }

        
        /// <summary>
        /// Test DeleteEnvironment
        /// </summary>
        [Test]
        public void DeleteEnvironmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.DeleteEnvironment(uuid);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DeleteEnvironmentSubscription
        /// </summary>
        [Test]
        public void DeleteEnvironmentSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.DeleteEnvironmentSubscription(uuid);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetEnvironment
        /// </summary>
        [Test]
        public void GetEnvironmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.GetEnvironment(uuid);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetEnvironments
        /// </summary>
        [Test]
        public void GetEnvironmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string created = null;
            //string limit = null;
            //string name = null;
            //string offset = null;
            //var response = instance.GetEnvironments(authorization, created, limit, name, offset);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetPublishedEnvironments
        /// </summary>
        [Test]
        public void GetPublishedEnvironmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string limit = null;
            //string name = null;
            //string offset = null;
            //var response = instance.GetPublishedEnvironments(limit, name, offset);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetSubscribedEnvironments
        /// </summary>
        [Test]
        public void GetSubscribedEnvironmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string limit = null;
            //string offset = null;
            //var response = instance.GetSubscribedEnvironments(limit, offset);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PublishEnvironment
        /// </summary>
        [Test]
        public void PublishEnvironmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JsonEnvironmentPublishingRequest body = null;
            //var response = instance.PublishEnvironment(body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test SubscribeEnvironment
        /// </summary>
        [Test]
        public void SubscribeEnvironmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.SubscribeEnvironment(uuid);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test UpdateEnvironment
        /// </summary>
        [Test]
        public void UpdateEnvironmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //JsonEnvironment body = null;
            //var response = instance.UpdateEnvironment(uuid, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
    }

}
