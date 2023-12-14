// <copyright file="ChartsPrescriberControllerTest.cs" company="APIMatic">
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
    /// ChartsPrescriberControllerTest.
    /// </summary>
    [TestFixture]
    public class ChartsPrescriberControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ChartsPrescriberController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ChartsPrescriberController;
        }

        /// <summary>
        /// Request --> Expects a request XML message with header and payload.
        ///            
        ///Response --> An XML response with a header segment.
        ///             The header segment has Result segment which includes the Code and List of error messages. Each message segment under it has an error number and description.
        ///            
        ///Sample Response (Result segment)
        ///<RESULT><CODE>ERROR</CODE><MESSAGES><MESSAGE><NUMBER>3001</NUMBER><DESCRIPTION>Invalid API Key format</DESCRIPTION></MESSAGE></MESSAGES></RESULT>.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestToCreateANewMedicationChart()
        {
            // Perform API call
            try
            {
                await this.controller.ToCreateANewMedicationChartAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsPrescriberCancelChart_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsPrescriberCancelChartPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsPrescriberCancelChartPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsPrescriberSynchroniseChart_PUT.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsPrescriberSynchroniseChartPUT()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsPrescriberSynchroniseChartPUTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsPrescriberResendToken_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsPrescriberResendTokenPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsPrescriberResendTokenPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint MdspesChartsPrescriberViewChart_POST.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestMdspesChartsPrescriberViewChartPOST()
        {
            // Perform API call
            try
            {
                await this.controller.MdspesChartsPrescriberViewChartPOSTAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}