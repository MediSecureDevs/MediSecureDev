// <copyright file="OpenAPIDocumentMedisecurePesApiClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace OpenAPIDocumentMedisecurePesApi.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using OpenAPIDocumentMedisecurePesApi.Standard.Authentication;
    using OpenAPIDocumentMedisecurePesApi.Standard.Controllers;
    using OpenAPIDocumentMedisecurePesApi.Standard.Http.Client;
    using OpenAPIDocumentMedisecurePesApi.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class OpenAPIDocumentMedisecurePesApiClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://{defaultHost}" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallBack httpCallBack;
        private readonly BearerAuthManager bearerAuthManager;
        private readonly Lazy<ChartsDispenserController> chartsDispenser;
        private readonly Lazy<ChartsPrescriberController> chartsPrescriber;
        private readonly Lazy<DispenserController> dispenser;
        private readonly Lazy<ErrorController> error;
        private readonly Lazy<MkFhirFacadeConnectorController> mkFhirFacadeConnector;
        private readonly Lazy<PrescriberController> prescriber;

        private OpenAPIDocumentMedisecurePesApiClient(
            Environment environment,
            string defaultHost,
            string accessToken,
            HttpCallBack httpCallBack,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.DefaultHost = defaultHost;
            this.httpCallBack = httpCallBack;
            this.HttpClientConfiguration = httpClientConfiguration;
            bearerAuthManager = new BearerAuthManager(accessToken);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                        {"global", bearerAuthManager}
                })
                .ApiCallback(httpCallBack)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .Parameters(globalParameter => globalParameter
                    .Template(templateParameter => templateParameter.Setup("defaultHost", this.DefaultHost)))
                .UserAgent(userAgent)
                .Build();


            this.chartsDispenser = new Lazy<ChartsDispenserController>(
                () => new ChartsDispenserController(globalConfiguration));
            this.chartsPrescriber = new Lazy<ChartsPrescriberController>(
                () => new ChartsPrescriberController(globalConfiguration));
            this.dispenser = new Lazy<DispenserController>(
                () => new DispenserController(globalConfiguration));
            this.error = new Lazy<ErrorController>(
                () => new ErrorController(globalConfiguration));
            this.mkFhirFacadeConnector = new Lazy<MkFhirFacadeConnectorController>(
                () => new MkFhirFacadeConnectorController(globalConfiguration));
            this.prescriber = new Lazy<PrescriberController>(
                () => new PrescriberController(globalConfiguration));
        }

        /// <summary>
        /// Gets ChartsDispenserController controller.
        /// </summary>
        public ChartsDispenserController ChartsDispenserController => this.chartsDispenser.Value;

        /// <summary>
        /// Gets ChartsPrescriberController controller.
        /// </summary>
        public ChartsPrescriberController ChartsPrescriberController => this.chartsPrescriber.Value;

        /// <summary>
        /// Gets DispenserController controller.
        /// </summary>
        public DispenserController DispenserController => this.dispenser.Value;

        /// <summary>
        /// Gets ErrorController controller.
        /// </summary>
        public ErrorController ErrorController => this.error.Value;

        /// <summary>
        /// Gets MkFhirFacadeConnectorController controller.
        /// </summary>
        public MkFhirFacadeConnectorController MkFhirFacadeConnectorController => this.mkFhirFacadeConnector.Value;

        /// <summary>
        /// Gets PrescriberController controller.
        /// </summary>
        public PrescriberController PrescriberController => this.prescriber.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets DefaultHost.
        /// DefaultHost value.
        /// </summary>
        public string DefaultHost { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        internal HttpCallBack HttpCallBack => this.httpCallBack;

        /// <summary>
        /// Gets the credentials to use with BearerAuth.
        /// </summary>
        private IBearerAuthCredentials BearerAuthCredentials => this.bearerAuthManager;

        /// <summary>
        /// Gets the access token to use with OAuth 2 authentication.
        /// </summary>
        public string AccessToken => this.BearerAuthCredentials.AccessToken;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the OpenAPIDocumentMedisecurePesApiClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .DefaultHost(this.DefaultHost)
                .AccessToken(BearerAuthCredentials.AccessToken)
                .HttpCallBack(httpCallBack)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"DefaultHost = {this.DefaultHost}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> OpenAPIDocumentMedisecurePesApiClient.</returns>
        internal static OpenAPIDocumentMedisecurePesApiClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("OPEN_API_DOCUMENT_MEDISECURE_PES_API_STANDARD_ENVIRONMENT");
            string defaultHost = System.Environment.GetEnvironmentVariable("OPEN_API_DOCUMENT_MEDISECURE_PES_API_STANDARD_DEFAULT_HOST");
            string accessToken = System.Environment.GetEnvironmentVariable("OPEN_API_DOCUMENT_MEDISECURE_PES_API_STANDARD_ACCESS_TOKEN");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (defaultHost != null)
            {
                builder.DefaultHost(defaultHost);
            }

            if (accessToken != null)
            {
                builder.AccessToken(accessToken);
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = OpenAPIDocumentMedisecurePesApi.Standard.Environment.Production;
            private string defaultHost = "www.example.com";
            private string accessToken = "";
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallBack httpCallBack;

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="accessToken">AccessToken.</param>
            /// <returns>Builder.</returns>
            public Builder AccessToken(string accessToken)
            {
                this.accessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets DefaultHost.
            /// </summary>
            /// <param name="defaultHost"> DefaultHost. </param>
            /// <returns> Builder. </returns>
            public Builder DefaultHost(string defaultHost)
            {
                this.defaultHost = defaultHost ?? throw new ArgumentNullException(nameof(defaultHost));
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

           

            /// <summary>
            /// Sets the HttpCallBack for the Builder.
            /// </summary>
            /// <param name="httpCallBack"> http callback. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpCallBack(HttpCallBack httpCallBack)
            {
                this.httpCallBack = httpCallBack;
                return this;
            }

            /// <summary>
            /// Creates an object of the OpenAPIDocumentMedisecurePesApiClient using the values provided for the builder.
            /// </summary>
            /// <returns>OpenAPIDocumentMedisecurePesApiClient.</returns>
            public OpenAPIDocumentMedisecurePesApiClient Build()
            {

                return new OpenAPIDocumentMedisecurePesApiClient(
                    environment,
                    defaultHost,
                    accessToken,
                    httpCallBack,
                    httpClientConfig.Build());
            }
        }
    }
}
