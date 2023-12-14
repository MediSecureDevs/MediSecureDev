// <copyright file="ChartsDispenserController.cs" company="APIMatic">
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
    /// ChartsDispenserController.
    /// </summary>
    public class ChartsDispenserController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartsDispenserController"/> class.
        /// </summary>
        internal ChartsDispenserController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// MdspesChartsDispenserReverseDispensedChartItem_POST EndPoint.
        /// </summary>
        public void MdspesChartsDispenserReverseDispensedChartItemPOST()
            => CoreHelper.RunVoidTask(MdspesChartsDispenserReverseDispensedChartItemPOSTAsync());

        /// <summary>
        /// MdspesChartsDispenserReverseDispensedChartItem_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsDispenserReverseDispensedChartItemPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/dispenser/ReverseDispensedChartItem")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsDispenserViewChart_POST EndPoint.
        /// </summary>
        public void MdspesChartsDispenserViewChartPOST()
            => CoreHelper.RunVoidTask(MdspesChartsDispenserViewChartPOSTAsync());

        /// <summary>
        /// MdspesChartsDispenserViewChart_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsDispenserViewChartPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/dispenser/ViewChart")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsDispenserDisableChartItem_POST EndPoint.
        /// </summary>
        public void MdspesChartsDispenserDisableChartItemPOST()
            => CoreHelper.RunVoidTask(MdspesChartsDispenserDisableChartItemPOSTAsync());

        /// <summary>
        /// MdspesChartsDispenserDisableChartItem_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsDispenserDisableChartItemPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/dispenser/DisableChartItem")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsDispenserGet_GET EndPoint.
        /// </summary>
        /// <returns>Returns the string response from the API call.</returns>
        public string MdspesChartsDispenserGetGET()
            => CoreHelper.RunTask(MdspesChartsDispenserGetGETAsync());

        /// <summary>
        /// MdspesChartsDispenserGet_GET EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        public async Task<string> MdspesChartsDispenserGetGETAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/mdspes/charts/dispenser/Get")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsDispenserDispenseChartItem_POST EndPoint.
        /// </summary>
        public void MdspesChartsDispenserDispenseChartItemPOST()
            => CoreHelper.RunVoidTask(MdspesChartsDispenserDispenseChartItemPOSTAsync());

        /// <summary>
        /// MdspesChartsDispenserDispenseChartItem_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsDispenserDispenseChartItemPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/dispenser/DispenseChartItem")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsDispenserEnableChartItem_POST EndPoint.
        /// </summary>
        public void MdspesChartsDispenserEnableChartItemPOST()
            => CoreHelper.RunVoidTask(MdspesChartsDispenserEnableChartItemPOSTAsync());

        /// <summary>
        /// MdspesChartsDispenserEnableChartItem_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsDispenserEnableChartItemPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/dispenser/EnableChartItem")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsDispenserViewChartItem_POST EndPoint.
        /// </summary>
        public void MdspesChartsDispenserViewChartItemPOST()
            => CoreHelper.RunVoidTask(MdspesChartsDispenserViewChartItemPOSTAsync());

        /// <summary>
        /// MdspesChartsDispenserViewChartItem_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsDispenserViewChartItemPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/dispenser/ViewChartItem")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesChartsDispenserAmendDispensedChartItem_POST EndPoint.
        /// </summary>
        public void MdspesChartsDispenserAmendDispensedChartItemPOST()
            => CoreHelper.RunVoidTask(MdspesChartsDispenserAmendDispensedChartItemPOSTAsync());

        /// <summary>
        /// MdspesChartsDispenserAmendDispensedChartItem_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesChartsDispenserAmendDispensedChartItemPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/charts/dispenser/AmendDispensedChartItem")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);
    }
}