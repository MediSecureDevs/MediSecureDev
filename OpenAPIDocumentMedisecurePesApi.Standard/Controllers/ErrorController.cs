// <copyright file="ErrorController.cs" company="APIMatic">
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
    /// ErrorController.
    /// </summary>
    public class ErrorController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorController"/> class.
        /// </summary>
        internal ErrorController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// ErrorLocalDevelopment_GET EndPoint.
        /// </summary>
        public void ErrorLocalDevelopmentGET()
            => CoreHelper.RunVoidTask(ErrorLocalDevelopmentGETAsync());

        /// <summary>
        /// ErrorLocalDevelopment_GET EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ErrorLocalDevelopmentGETAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/error-local-development")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Error_GET EndPoint.
        /// </summary>
        public void ErrorGET()
            => CoreHelper.RunVoidTask(ErrorGETAsync());

        /// <summary>
        /// Error_GET EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ErrorGETAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/error")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);
    }
}