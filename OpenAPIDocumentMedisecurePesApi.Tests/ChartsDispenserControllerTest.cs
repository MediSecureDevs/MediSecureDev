// <copyright file="ChartsDispenserControllerTest.cs" company="APIMatic">
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
    /// ChartsDispenserControllerTest.
    /// </summary>
    [TestFixture]
    public class ChartsDispenserControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ChartsDispenserController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ChartsDispenserController;
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsDispenserReverseDispensedChartItem_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsDispenserReverseDispensedChartItemPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsDispenserReverseDispensedChartItemPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsDispenserViewChart_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsDispenserViewChartPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsDispenserViewChartPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsDispenserDisableChartItem_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsDispenserDisableChartItemPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsDispenserDisableChartItemPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsDispenserGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsDispenserGetGET()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesChartsDispenserGetGETAsync();
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
        /// Testcase for testing endpoint MdspesChartsDispenserGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsDispenserGetGET1()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesChartsDispenserGetGETAsync();
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
        /// Testcase for testing endpoint MdspesChartsDispenserGet_GET.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsDispenserGetGET2()
        {
            // Perform API call
            string result = null;
            try
            {
                result = await this.controller.MdspesChartsDispenserGetGETAsync();
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
        /// Testcase for testing endpoint MdspesChartsDispenserDispenseChartItem_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsDispenserDispenseChartItemPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsDispenserDispenseChartItemPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsDispenserEnableChartItem_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsDispenserEnableChartItemPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsDispenserEnableChartItemPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsDispenserViewChartItem_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsDispenserViewChartItemPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsDispenserViewChartItemPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsDispenserAmendDispensedChartItem_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsDispenserAmendDispensedChartItemPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsDispenserAmendDispensedChartItemPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}