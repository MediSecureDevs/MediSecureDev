// <copyright file="MkFhirFacadeConnectorControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace OpenAPIDocumentMedisecurePesApi.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;
    using OpenAPIDocumentMedisecurePesApi.Standard;
    using OpenAPIDocumentMedisecurePesApi.Standard.Controllers;
    using OpenAPIDocumentMedisecurePesApi.Standard.Exceptions;
    using OpenAPIDocumentMedisecurePesApi.Standard.Http.Client;
    using OpenAPIDocumentMedisecurePesApi.Standard.Http.Response;
    using OpenAPIDocumentMedisecurePesApi.Standard.Utilities;

    /// <summary>
    /// MkFhirFacadeConnectorControllerTest.
    /// </summary>
    [TestFixture]
    public class MkFhirFacadeConnectorControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private MkFhirFacadeConnectorController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.MkFhirFacadeConnectorController;
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesMkfhirfacadeGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesMkfhirfacadeGetGET1()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesMkfhirfacadeGetGETAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesMkfhirfacadeGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesMkfhirfacadeGetGET2()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesMkfhirfacadeGetGETAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "text/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesMkfhirfacadeGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesMkfhirfacadeGetGET()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesMkfhirfacadeGetGETAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "text/plain");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesMkfhirfacadeViewChart_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesMkfhirfacadeViewChartPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesMkfhirfacadeViewChartPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesMkfhirfacadeViewPrescription_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesMkfhirfacadeViewPrescriptionPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesMkfhirfacadeViewPrescriptionPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesMkfhirfacadeViewChartItem_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesMkfhirfacadeViewChartItemPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesMkfhirfacadeViewChartItemPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}