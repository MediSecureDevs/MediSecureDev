// <copyright file="DispenserController.cs" company="APIMatic">
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
    /// DispenserController.
    /// </summary>
    public class DispenserController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DispenserController"/> class.
        /// </summary>
        internal DispenserController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// MdspesScriptsDispenserGet_GET EndPoint.
        /// </summary>
        /// <returns>Returns the string response from the API call.</returns>
        public string MdspesScriptsDispenserGetGET()
            => CoreHelper.RunTask(MdspesScriptsDispenserGetGETAsync());

        /// <summary>
        /// MdspesScriptsDispenserGet_GET EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        public async Task<string> MdspesScriptsDispenserGetGETAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/mdspes/scripts/Dispenser/Get")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsDispenserViewPrescription_POST EndPoint.
        /// </summary>
        public void MdspesScriptsDispenserViewPrescriptionPOST()
            => CoreHelper.RunVoidTask(MdspesScriptsDispenserViewPrescriptionPOSTAsync());

        /// <summary>
        /// MdspesScriptsDispenserViewPrescription_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsDispenserViewPrescriptionPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Dispenser/ViewPrescription")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsDispenserAmendDispensedItem_POST EndPoint.
        /// </summary>
        public void MdspesScriptsDispenserAmendDispensedItemPOST()
            => CoreHelper.RunVoidTask(MdspesScriptsDispenserAmendDispensedItemPOSTAsync());

        /// <summary>
        /// MdspesScriptsDispenserAmendDispensedItem_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsDispenserAmendDispensedItemPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Dispenser/AmendDispensedItem")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsDispenserReverseDispensedItem_POST EndPoint.
        /// </summary>
        public void MdspesScriptsDispenserReverseDispensedItemPOST()
            => CoreHelper.RunVoidTask(MdspesScriptsDispenserReverseDispensedItemPOSTAsync());

        /// <summary>
        /// MdspesScriptsDispenserReverseDispensedItem_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsDispenserReverseDispensedItemPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Dispenser/ReverseDispensedItem")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsDispenserManualDispense_POST EndPoint.
        /// </summary>
        public void MdspesScriptsDispenserManualDispensePOST()
            => CoreHelper.RunVoidTask(MdspesScriptsDispenserManualDispensePOSTAsync());

        /// <summary>
        /// MdspesScriptsDispenserManualDispense_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsDispenserManualDispensePOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Dispenser/ManualDispense")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsDispenserInitiateDispense_POST EndPoint.
        /// </summary>
        public void MdspesScriptsDispenserInitiateDispensePOST()
            => CoreHelper.RunVoidTask(MdspesScriptsDispenserInitiateDispensePOSTAsync());

        /// <summary>
        /// MdspesScriptsDispenserInitiateDispense_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsDispenserInitiateDispensePOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Dispenser/InitiateDispense")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsDispenserTerminateDispense_POST EndPoint.
        /// </summary>
        public void MdspesScriptsDispenserTerminateDispensePOST()
            => CoreHelper.RunVoidTask(MdspesScriptsDispenserTerminateDispensePOSTAsync());

        /// <summary>
        /// MdspesScriptsDispenserTerminateDispense_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsDispenserTerminateDispensePOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Dispenser/TerminateDispense")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsDispenserElectronicDispense_POST EndPoint.
        /// </summary>
        public void MdspesScriptsDispenserElectronicDispensePOST()
            => CoreHelper.RunVoidTask(MdspesScriptsDispenserElectronicDispensePOSTAsync());

        /// <summary>
        /// MdspesScriptsDispenserElectronicDispense_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsDispenserElectronicDispensePOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Dispenser/ElectronicDispense")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsDispenserResendToken_POST EndPoint.
        /// </summary>
        public void MdspesScriptsDispenserResendTokenPOST()
            => CoreHelper.RunVoidTask(MdspesScriptsDispenserResendTokenPOSTAsync());

        /// <summary>
        /// MdspesScriptsDispenserResendToken_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsDispenserResendTokenPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Dispenser/ResendToken")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsDispenserDisableScript_POST EndPoint.
        /// </summary>
        public void MdspesScriptsDispenserDisableScriptPOST()
            => CoreHelper.RunVoidTask(MdspesScriptsDispenserDisableScriptPOSTAsync());

        /// <summary>
        /// MdspesScriptsDispenserDisableScript_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsDispenserDisableScriptPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Dispenser/DisableScript")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// MdspesScriptsDispenserEnableScript_POST EndPoint.
        /// </summary>
        public void MdspesScriptsDispenserEnableScriptPOST()
            => CoreHelper.RunVoidTask(MdspesScriptsDispenserEnableScriptPOSTAsync());

        /// <summary>
        /// MdspesScriptsDispenserEnableScript_POST EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MdspesScriptsDispenserEnableScriptPOSTAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/mdspes/scripts/Dispenser/EnableScript")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);
    }
}