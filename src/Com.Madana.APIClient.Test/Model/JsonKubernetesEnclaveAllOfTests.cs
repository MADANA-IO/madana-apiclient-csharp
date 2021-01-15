/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.26
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Model;
using Com.Madana.APIClient.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Com.Madana.APIClient.Test
{
    /// <summary>
    ///  Class for testing JsonKubernetesEnclaveAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class JsonKubernetesEnclaveAllOfTests
    {
        // TODO uncomment below to declare an instance variable for JsonKubernetesEnclaveAllOf
        //private JsonKubernetesEnclaveAllOf instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of JsonKubernetesEnclaveAllOf
            //instance = new JsonKubernetesEnclaveAllOf();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of JsonKubernetesEnclaveAllOf
        /// </summary>
        [Test]
        public void JsonKubernetesEnclaveAllOfInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" JsonKubernetesEnclaveAllOf
            //Assert.IsInstanceOf(typeof(JsonKubernetesEnclaveAllOf), instance);
        }


        /// <summary>
        /// Test the property 'EnclavePodEvents'
        /// </summary>
        [Test]
        public void EnclavePodEventsTest()
        {
            // TODO unit test for the property 'EnclavePodEvents'
        }
        /// <summary>
        /// Test the property 'RemoteControlIP'
        /// </summary>
        [Test]
        public void RemoteControlIPTest()
        {
            // TODO unit test for the property 'RemoteControlIP'
        }
        /// <summary>
        /// Test the property 'EnclaveReplicaSetEvents'
        /// </summary>
        [Test]
        public void EnclaveReplicaSetEventsTest()
        {
            // TODO unit test for the property 'EnclaveReplicaSetEvents'
        }
        /// <summary>
        /// Test the property 'AttestationPort'
        /// </summary>
        [Test]
        public void AttestationPortTest()
        {
            // TODO unit test for the property 'AttestationPort'
        }
        /// <summary>
        /// Test the property 'DebugInfo'
        /// </summary>
        [Test]
        public void DebugInfoTest()
        {
            // TODO unit test for the property 'DebugInfo'
        }
        /// <summary>
        /// Test the property 'PodPhase'
        /// </summary>
        [Test]
        public void PodPhaseTest()
        {
            // TODO unit test for the property 'PodPhase'
        }
        /// <summary>
        /// Test the property 'IsUsingInitContainer'
        /// </summary>
        [Test]
        public void IsUsingInitContainerTest()
        {
            // TODO unit test for the property 'IsUsingInitContainer'
        }
        /// <summary>
        /// Test the property 'WireguardPort'
        /// </summary>
        [Test]
        public void WireguardPortTest()
        {
            // TODO unit test for the property 'WireguardPort'
        }
        /// <summary>
        /// Test the property 'EnclaveDeploymentEvents'
        /// </summary>
        [Test]
        public void EnclaveDeploymentEventsTest()
        {
            // TODO unit test for the property 'EnclaveDeploymentEvents'
        }

    }

}
