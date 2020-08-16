/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.4.14-master.16
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

using Com.MadanaSampleclient.Client;
using Com.MadanaSampleclient.Api;
using Com.MadanaSampleclient.Model;

namespace Com.MadanaSampleclient.Test
{
    /// <summary>
    ///  Class for testing CertificateServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CertificateServiceApiTests
    {
        private CertificateServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CertificateServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CertificateServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' CertificateServiceApi
            //Assert.IsInstanceOf(typeof(CertificateServiceApi), instance);
        }

        
        /// <summary>
        /// Test AuthenticateCertificate
        /// </summary>
        [Test]
        public void AuthenticateCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JsonMDNData body = null;
            //var response = instance.AuthenticateCertificate(body);
            //Assert.IsInstanceOf(typeof(JsonMDNCertificate), response, "response is JsonMDNCertificate");
        }
        
        /// <summary>
        /// Test GetCertificate
        /// </summary>
        [Test]
        public void GetCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCertificate();
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetCertificate_0
        /// </summary>
        [Test]
        public void GetCertificate_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fingerprint = null;
            //var response = instance.GetCertificate_0(fingerprint);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
    }

}
