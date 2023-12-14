
# Getting Started with Open API Document - Medisecure.Pes.Api

## Introduction

Documentation for all supported API's by Medisecure for ETP / PES

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (OpenAPIDocumentMedisecurePesApi.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

The supported version is **.NET Standard 2.0**. For checking compatibility of your .NET implementation with the generated library, [click here](https://dotnet.microsoft.com/en-us/platform/dotnet-standard#versions).

## Installation

The following section explains how to use the OpenAPIDocumentMedisecurePesApi.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Open%20API%20Document%20-%20Medisecure.Pes.Api-CSharp&workspaceName=OpenAPIDocumentMedisecurePesApi&projectName=OpenAPIDocumentMedisecurePesApi.Standard&rootNamespace=OpenAPIDocumentMedisecurePesApi.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Open%20API%20Document%20-%20Medisecure.Pes.Api-CSharp&workspaceName=OpenAPIDocumentMedisecurePesApi&projectName=OpenAPIDocumentMedisecurePesApi.Standard&rootNamespace=OpenAPIDocumentMedisecurePesApi.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Open%20API%20Document%20-%20Medisecure.Pes.Api-CSharp&workspaceName=OpenAPIDocumentMedisecurePesApi&projectName=OpenAPIDocumentMedisecurePesApi.Standard&rootNamespace=OpenAPIDocumentMedisecurePesApi.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the `OpenAPIDocumentMedisecurePesApi.Standard` library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Open%20API%20Document%20-%20Medisecure.Pes.Api-CSharp&workspaceName=OpenAPIDocumentMedisecurePesApi&projectName=OpenAPIDocumentMedisecurePesApi.Standard&rootNamespace=OpenAPIDocumentMedisecurePesApi.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `OpenAPIDocumentMedisecurePesApi.Standard` and click `OK`. By doing this, we have added a reference of the `OpenAPIDocumentMedisecurePesApi.Standard` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Open%20API%20Document%20-%20Medisecure.Pes.Api-CSharp&workspaceName=OpenAPIDocumentMedisecurePesApi&projectName=OpenAPIDocumentMedisecurePesApi.Standard&rootNamespace=OpenAPIDocumentMedisecurePesApi.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Open%20API%20Document%20-%20Medisecure.Pes.Api-CSharp&workspaceName=OpenAPIDocumentMedisecurePesApi&projectName=OpenAPIDocumentMedisecurePesApi.Standard&rootNamespace=OpenAPIDocumentMedisecurePesApi.Standard&step=addCode)

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `DefaultHost` | `string` | *Default*: `"www.example.com"` |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `AccessToken` | `string` | The OAuth 2.0 Access Token to use for API requests. |

The API client can be initialized as follows:

```csharp
OpenAPIDocumentMedisecurePesApi.Standard.OpenAPIDocumentMedisecurePesApiClient client = new OpenAPIDocumentMedisecurePesApi.Standard.OpenAPIDocumentMedisecurePesApiClient.Builder()
    .AccessToken("AccessToken")
    .Environment(OpenAPIDocumentMedisecurePesApi.Standard.Environment.Production)
    .DefaultHost("www.example.com")
    .Build();
```

## Authorization

This API uses `OAuth 2 Bearer token`.

## List of APIs

* [Charts Dispenser](doc/controllers/charts-dispenser.md)
* [Charts Prescriber](doc/controllers/charts-prescriber.md)
* [Dispenser](doc/controllers/dispenser.md)
* [Error](doc/controllers/error.md)
* [Mk Fhir Facade Connector](doc/controllers/mk-fhir-facade-connector.md)
* [Prescriber](doc/controllers/prescriber.md)

## Classes Documentation

* [Utility Classes](doc/utility-classes.md)
* [HttpRequest](doc/http-request.md)
* [HttpResponse](doc/http-response.md)
* [HttpStringResponse](doc/http-string-response.md)
* [HttpContext](doc/http-context.md)
* [HttpClientConfiguration](doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](doc/http-client-configuration-builder.md)
* [IAuthManager](doc/i-auth-manager.md)
* [ApiException](doc/api-exception.md)

