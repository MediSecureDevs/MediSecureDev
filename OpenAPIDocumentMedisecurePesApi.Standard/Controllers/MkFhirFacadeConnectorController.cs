// <copyright file="MkFhirFacadeConnectorController.cs" company="APIMatic">
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
    /// MkFhirFacadeConnectorController.
    /// </summary>
    public class MkFhirFacadeConnectorController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MkFhirFacadeConnectorController"/> class.
        /// </summary>
        internal MkFhirFacadeConnectorController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// MdspesMkfhirfacadeGet_GET EndPoint.
        /// </summary>
        /// <returns>Returns the string response from the API call.</returns>
        public string MdspesMkfhirfacadeGetGET()
            => CoreHelper.RunTask(MdspesMkfhirfacadeGetGETAsync());

        /// <summary>
        /// MdspesMkfhirfacadeGet_GET EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        public async Task<string> MdspesMkfhirfacadeGetGETAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/mdspes/mkfhirfacade/Get")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesMkfhirfacadeViewChart_POST EndPoint.
        /// </summary>
        public void MdspesMkfhirfacadeViewChartPOST()
            => CoreHelper.RunVoidTask(MdspesMkfhirfacadeViewChartPOSTAsync());

        /// <summary>
        /// MdspesMkfhirfacadeViewChart_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesMkfhirfacadeViewChartPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/mkfhirfacade/ViewChart")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesMkfhirfacadeViewPrescription_POST EndPoint.
        /// </summary>
        public void MdspesMkfhirfacadeViewPrescriptionPOST()
            => CoreHelper.RunVoidTask(MdspesMkfhirfacadeViewPrescriptionPOSTAsync());

        /// <summary>
        /// MdspesMkfhirfacadeViewPrescription_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesMkfhirfacadeViewPrescriptionPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/mkfhirfacade/ViewPrescription")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesMkfhirfacadeViewChartItem_POST EndPoint.
        /// </summary>
        public void MdspesMkfhirfacadeViewChartItemPOST()
            => CoreHelper.RunVoidTask(MdspesMkfhirfacadeViewChartItemPOSTAsync());

        /// <summary>
        /// MdspesMkfhirfacadeViewChartItem_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesMkfhirfacadeViewChartItemPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/mkfhirfacade/ViewChartItem")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);
    }
}