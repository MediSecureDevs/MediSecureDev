// <copyright file="PrescriberControllerTest.cs" company="APIMatic">
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
    /// PrescriberControllerTest.
    /// </summary>
    [TestFixture]
    public class PrescriberControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private PrescriberController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.PrescriberController;
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsPrescriberUploadPrescription_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsPrescriberUploadPrescriptionPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsPrescriberUploadPrescriptionPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsPrescriberCancelPrescription_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsPrescriberCancelPrescriptionPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsPrescriberCancelPrescriptionPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsPrescriberGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsPrescriberGetGET1()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesScriptsPrescriberGetGETAsync();
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
        /// Testcase for testing endpoint MdspesScriptsPrescriberGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsPrescriberGetGET()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesScriptsPrescriberGetGETAsync();
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
        /// Testcase for testing endpoint MdspesScriptsPrescriberGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsPrescriberGetGET2()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesScriptsPrescriberGetGETAsync();
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
        /// Testcase for testing endpoint MdspesScriptsPrescriberCeasePrescription_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsPrescriberCeasePrescriptionPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsPrescriberCeasePrescriptionPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsPrescriberResendToken_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsPrescriberResendTokenPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsPrescriberResendTokenPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}