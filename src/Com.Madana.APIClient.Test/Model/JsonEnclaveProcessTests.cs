/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.35
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
    ///  Class for testing JsonEnclaveProcess
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class JsonEnclaveProcessTests
    {
        // TODO uncomment below to declare an instance variable for JsonEnclaveProcess
        //private JsonEnclaveProcess instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of JsonEnclaveProcess
            //instance = new JsonEnclaveProcess();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of JsonEnclaveProcess
        /// </summary>
        [Test]
        public void JsonEnclaveProcessInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" JsonEnclaveProcess
            //Assert.IsInstanceOf(typeof(JsonEnclaveProcess), instance);
        }


        /// <summary>
        /// Test the property 'WgInterface'
        /// </summary>
        [Test]
        public void WgInterfaceTest()
        {
            // TODO unit test for the property 'WgInterface'
        }
        /// <summary>
        /// Test the property 'Environment'
        /// </summary>
        [Test]
        public void EnvironmentTest()
        {
            // TODO unit test for the property 'Environment'
        }
        /// <summary>
        /// Test the property 'StartupCMD'
        /// </summary>
        [Test]
        public void StartupCMDTest()
        {
            // TODO unit test for the property 'StartupCMD'
        }
        /// <summary>
        /// Test the property 'InternalRemoteControlServer'
        /// </summary>
        [Test]
        public void InternalRemoteControlServerTest()
        {
            // TODO unit test for the property 'InternalRemoteControlServer'
        }
        /// <summary>
        /// Test the property 'ConsoleOutput'
        /// </summary>
        [Test]
        public void ConsoleOutputTest()
        {
            // TODO unit test for the property 'ConsoleOutput'
        }
        /// <summary>
        /// Test the property 'EndingTime'
        /// </summary>
        [Test]
        public void EndingTimeTest()
        {
            // TODO unit test for the property 'EndingTime'
        }
        /// <summary>
        /// Test the property 'StartupTime'
        /// </summary>
        [Test]
        public void StartupTimeTest()
        {
            // TODO unit test for the property 'StartupTime'
        }
        /// <summary>
        /// Test the property 'RemoteControlServer'
        /// </summary>
        [Test]
        public void RemoteControlServerTest()
        {
            // TODO unit test for the property 'RemoteControlServer'
        }
        /// <summary>
        /// Test the property 'Ports'
        /// </summary>
        [Test]
        public void PortsTest()
        {
            // TODO unit test for the property 'Ports'
        }
        /// <summary>
        /// Test the property 'KubernetesEnclave'
        /// </summary>
        [Test]
        public void KubernetesEnclaveTest()
        {
            // TODO unit test for the property 'KubernetesEnclave'
        }
        /// <summary>
        /// Test the property 'WireguardServer'
        /// </summary>
        [Test]
        public void WireguardServerTest()
        {
            // TODO unit test for the property 'WireguardServer'
        }
        /// <summary>
        /// Test the property 'InternalWireguardServer'
        /// </summary>
        [Test]
        public void InternalWireguardServerTest()
        {
            // TODO unit test for the property 'InternalWireguardServer'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'WireguardPublicKey'
        /// </summary>
        [Test]
        public void WireguardPublicKeyTest()
        {
            // TODO unit test for the property 'WireguardPublicKey'
        }
        /// <summary>
        /// Test the property 'EnclaveIdent'
        /// </summary>
        [Test]
        public void EnclaveIdentTest()
        {
            // TODO unit test for the property 'EnclaveIdent'
        }
        /// <summary>
        /// Test the property 'InternalIdent'
        /// </summary>
        [Test]
        public void InternalIdentTest()
        {
            // TODO unit test for the property 'InternalIdent'
        }
        /// <summary>
        /// Test the property 'PublicIdent'
        /// </summary>
        [Test]
        public void PublicIdentTest()
        {
            // TODO unit test for the property 'PublicIdent'
        }
        /// <summary>
        /// Test the property 'Process'
        /// </summary>
        [Test]
        public void ProcessTest()
        {
            // TODO unit test for the property 'Process'
        }
        /// <summary>
        /// Test the property 'InternalAttesationServer'
        /// </summary>
        [Test]
        public void InternalAttesationServerTest()
        {
            // TODO unit test for the property 'InternalAttesationServer'
        }
        /// <summary>
        /// Test the property 'SignerIdent'
        /// </summary>
        [Test]
        public void SignerIdentTest()
        {
            // TODO unit test for the property 'SignerIdent'
        }
        /// <summary>
        /// Test the property 'EnclaveInputstream'
        /// </summary>
        [Test]
        public void EnclaveInputstreamTest()
        {
            // TODO unit test for the property 'EnclaveInputstream'
        }
        /// <summary>
        /// Test the property 'AttestationServer'
        /// </summary>
        [Test]
        public void AttestationServerTest()
        {
            // TODO unit test for the property 'AttestationServer'
        }
        /// <summary>
        /// Test the property 'PortMapping'
        /// </summary>
        [Test]
        public void PortMappingTest()
        {
            // TODO unit test for the property 'PortMapping'
        }

    }

}
