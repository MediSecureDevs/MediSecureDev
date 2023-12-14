// <copyright file="DispenserControllerTest.cs" company="APIMatic">
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
    /// DispenserControllerTest.
    /// </summary>
    [TestFixture]
    public class DispenserControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private DispenserController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.DispenserController;
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsDispenserGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserGetGET2()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesScriptsDispenserGetGETAsync();
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
        /// Testcase for testing endpoint MdspesScriptsDispenserGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserGetGET()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesScriptsDispenserGetGETAsync();
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
        /// Testcase for testing endpoint MdspesScriptsDispenserGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserGetGET1()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesScriptsDispenserGetGETAsync();
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
        /// Testcase for testing endpoint MdspesScriptsDispenserViewPrescription_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserViewPrescriptionPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsDispenserViewPrescriptionPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsDispenserAmendDispensedItem_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserAmendDispensedItemPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsDispenserAmendDispensedItemPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsDispenserReverseDispensedItem_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserReverseDispensedItemPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsDispenserReverseDispensedItemPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsDispenserManualDispense_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserManualDispensePOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsDispenserManualDispensePOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsDispenserInitiateDispense_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserInitiateDispensePOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsDispenserInitiateDispensePOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsDispenserTerminateDispense_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserTerminateDispensePOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsDispenserTerminateDispensePOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsDispenserElectronicDispense_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserElectronicDispensePOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsDispenserElectronicDispensePOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsDispenserResendToken_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserResendTokenPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsDispenserResendTokenPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsDispenserDisableScript_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserDisableScriptPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsDispenserDisableScriptPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesScriptsDispenserEnableScript_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesScriptsDispenserEnableScriptPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesScriptsDispenserEnableScriptPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}