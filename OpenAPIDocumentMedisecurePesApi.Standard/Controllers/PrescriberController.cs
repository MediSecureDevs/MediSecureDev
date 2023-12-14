// <copyright file="PrescriberController.cs" company="APIMatic">
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
    /// PrescriberController.
    /// </summary>
    public class PrescriberController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrescriberController"/> class.
        /// </summary>
        internal PrescriberController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// MdspesScriptsPrescriberUploadPrescription_POST EndPoint.
        /// </summary>
        public void MdspesScriptsPrescriberUploadPrescriptionPOST()
            => CoreHelper.RunVoidTask(MdspesScriptsPrescriberUploadPrescriptionPOSTAsync());

        /// <summary>
        /// MdspesScriptsPrescriberUploadPrescription_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsPrescriberUploadPrescriptionPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Prescriber/UploadPrescription")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsPrescriberCancelPrescription_POST EndPoint.
        /// </summary>
        public void MdspesScriptsPrescriberCancelPrescriptionPOST()
            => CoreHelper.RunVoidTask(MdspesScriptsPrescriberCancelPrescriptionPOSTAsync());

        /// <summary>
        /// MdspesScriptsPrescriberCancelPrescription_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsPrescriberCancelPrescriptionPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Prescriber/CancelPrescription")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsPrescriberGet_GET EndPoint.
        /// </summary>
        /// <returns>Returns the string response from the API call.</returns>
        public string MdspesScriptsPrescriberGetGET()
            => CoreHelper.RunTask(MdspesScriptsPrescriberGetGETAsync());

        /// <summary>
        /// MdspesScriptsPrescriberGet_GET EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        public async Task<string> MdspesScriptsPrescriberGetGETAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/mdspes/scripts/Prescriber/Get")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsPrescriberCeasePrescription_POST EndPoint.
        /// </summary>
        public void MdspesScriptsPrescriberCeasePrescriptionPOST()
            => CoreHelper.RunVoidTask(MdspesScriptsPrescriberCeasePrescriptionPOSTAsync());

        /// <summary>
        /// MdspesScriptsPrescriberCeasePrescription_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsPrescriberCeasePrescriptionPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Prescriber/CeasePrescription")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsPrescriberResendToken_POST EndPoint.
        /// </summary>
        public void MdspesScriptsPrescriberResendTokenPOST()
            => CoreHelper.RunVoidTask(MdspesScriptsPrescriberResendTokenPOSTAsync());

        /// <summary>
        /// MdspesScriptsPrescriberResendToken_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsPrescriberResendTokenPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Prescriber/ResendToken")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);
    }
}