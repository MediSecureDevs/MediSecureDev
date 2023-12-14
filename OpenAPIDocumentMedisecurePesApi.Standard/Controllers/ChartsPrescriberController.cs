// <copyright file="ChartsPrescriberController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace OpenAPIDocumentMedisecurePesApi.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using OpenAPIDocumentMedisecurePesApi.Standard;
    using OpenAPIDocumentMedisecurePesApi.Standard.Authentication;
    using OpenAPIDocumentMedisecurePesApi.Standard.Http.Client;
    using OpenAPIDocumentMedisecurePesApi.Standard.Utilities;
    using System.Net.Http;

    /// <summary>
    /// ChartsPrescriberController.
    /// </summary>
    public class ChartsPrescriberController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartsPrescriberController"/> class.
        /// </summary>
        internal ChartsPrescriberController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Request --> Expects a request XML message with header and payload.
        ///             .
        /// Response --> An XML response with a header segment.
        ///              The header segment has Result segment which includes the Code and List of error messages. Each message segment under it has an error number and description.
        ///             .
        /// Sample Response (Result segment).
        /// <RESULT><CODE>ERROR</CODE><MESSAGES><MESSAGE><NUMBER>3001</NUMBER><DESCRIPTION>Invalid API Key format</DESCRIPTION></MESSAGE></MESSAGES></RESULT>.
        /// </summary>
        public void ToCreateANewMedicationChart()
            => CoreHelper.RunVoidTask(ToCreateANewMedicationChartAsync());

        /// <summary>
        /// Request --> Expects a request XML message with header and payload.
        ///             .
        /// Response --> An XML response with a header segment.
        ///              The header segment has Result segment which includes the Code and List of error messages. Each message segment under it has an error number and description.
        ///             .
        /// Sample Response (Result segment).
        /// <RESULT><CODE>ERROR</CODE><MESSAGES><MESSAGE><NUMBER>3001</NUMBER><DESCRIPTION>Invalid API Key format</DESCRIPTION></MESSAGE></MESSAGES></RESULT>.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ToCreateANewMedicationChartAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/prescriber/CreateChart")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsPrescriberCancelChart_POST EndPoint.
        /// </summary>
        public void MdspesChartsPrescriberCancelChartPOST()
            => CoreHelper.RunVoidTask(MdspesChartsPrescriberCancelChartPOSTAsync());

        /// <summary>
        /// MdspesChartsPrescriberCancelChart_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsPrescriberCancelChartPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/prescriber/CancelChart")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsPrescriberSynchroniseChart_PUT EndPoint.
        /// </summary>
        public void MdspesChartsPrescriberSynchroniseChartPUT()
            => CoreHelper.RunVoidTask(MdspesChartsPrescriberSynchroniseChartPUTAsync());

        /// <summary>
        /// MdspesChartsPrescriberSynchroniseChart_PUT EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsPrescriberSynchroniseChartPUTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/mdspes/charts/prescriber/SynchroniseChart")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsPrescriberResendToken_POST EndPoint.
        /// </summary>
        public void MdspesChartsPrescriberResendTokenPOST()
            => CoreHelper.RunVoidTask(MdspesChartsPrescriberResendTokenPOSTAsync());

        /// <summary>
        /// MdspesChartsPrescriberResendToken_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsPrescriberResendTokenPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/prescriber/ResendToken")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsPrescriberViewChart_POST EndPoint.
        /// </summary>
        public void MdspesChartsPrescriberViewChartPOST()
            => CoreHelper.RunVoidTask(MdspesChartsPrescriberViewChartPOSTAsync());

        /// <summary>
        /// MdspesChartsPrescriberViewChart_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsPrescriberViewChartPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/prescriber/ViewChart")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);
    }
}