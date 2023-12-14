# Mk Fhir Facade Connector

```csharp
MkFhirFacadeConnectorController mkFhirFacadeConnectorController = client.MkFhirFacadeConnectorController;
```

## Class Name

`MkFhirFacadeConnectorController`

## Methods

* [Mdspes Mkfhirfacade Get GET](../../doc/controllers/mk-fhir-facade-connector.md#mdspes-mkfhirfacade-get-get)
* [Mdspes Mkfhirfacade View Chart POST](../../doc/controllers/mk-fhir-facade-connector.md#mdspes-mkfhirfacade-view-chart-post)
* [Mdspes Mkfhirfacade View Prescription POST](../../doc/controllers/mk-fhir-facade-connector.md#mdspes-mkfhirfacade-view-prescription-post)
* [Mdspes Mkfhirfacade View Chart Item POST](../../doc/controllers/mk-fhir-facade-connector.md#mdspes-mkfhirfacade-view-chart-item-post)


# Mdspes Mkfhirfacade Get GET

```csharp
MdspesMkfhirfacadeGetGETAsync()
```

## Response Type

`Task<string>`

## Example Usage

```csharp
try
{
    string result = await mkFhirFacadeConnectorController.MdspesMkfhirfacadeGetGETAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Mkfhirfacade View Chart POST

```csharp
MdspesMkfhirfacadeViewChartPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await mkFhirFacadeConnectorController.MdspesMkfhirfacadeViewChartPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Mkfhirfacade View Prescription POST

```csharp
MdspesMkfhirfacadeViewPrescriptionPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await mkFhirFacadeConnectorController.MdspesMkfhirfacadeViewPrescriptionPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Mkfhirfacade View Chart Item POST

```csharp
MdspesMkfhirfacadeViewChartItemPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await mkFhirFacadeConnectorController.MdspesMkfhirfacadeViewChartItemPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

