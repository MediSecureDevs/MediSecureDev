# Charts Prescriber

```csharp
ChartsPrescriberController chartsPrescriberController = client.ChartsPrescriberController;
```

## Class Name

`ChartsPrescriberController`

## Methods

* [To Create a New Medication Chart](../../doc/controllers/charts-prescriber.md#to-create-a-new-medication-chart)
* [Mdspes Charts Prescriber Cancel Chart POST](../../doc/controllers/charts-prescriber.md#mdspes-charts-prescriber-cancel-chart-post)
* [Mdspes Charts Prescriber Synchronise Chart PUT](../../doc/controllers/charts-prescriber.md#mdspes-charts-prescriber-synchronise-chart-put)
* [Mdspes Charts Prescriber Resend Token POST](../../doc/controllers/charts-prescriber.md#mdspes-charts-prescriber-resend-token-post)
* [Mdspes Charts Prescriber View Chart POST](../../doc/controllers/charts-prescriber.md#mdspes-charts-prescriber-view-chart-post)


# To Create a New Medication Chart

Request --> Expects a request XML message with header and payload.

Response --> An XML response with a header segment.
The header segment has Result segment which includes the Code and List of error messages. Each message segment under it has an error number and description.

Sample Response (Result segment)
<RESULT><CODE>ERROR</CODE><MESSAGES><MESSAGE><NUMBER>3001</NUMBER><DESCRIPTION>Invalid API Key format</DESCRIPTION></MESSAGE></MESSAGES></RESULT>

```csharp
ToCreateANewMedicationChartAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await chartsPrescriberController.ToCreateANewMedicationChartAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Charts Prescriber Cancel Chart POST

```csharp
MdspesChartsPrescriberCancelChartPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await chartsPrescriberController.MdspesChartsPrescriberCancelChartPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Charts Prescriber Synchronise Chart PUT

```csharp
MdspesChartsPrescriberSynchroniseChartPUTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await chartsPrescriberController.MdspesChartsPrescriberSynchroniseChartPUTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Charts Prescriber Resend Token POST

```csharp
MdspesChartsPrescriberResendTokenPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await chartsPrescriberController.MdspesChartsPrescriberResendTokenPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Charts Prescriber View Chart POST

```csharp
MdspesChartsPrescriberViewChartPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await chartsPrescriberController.MdspesChartsPrescriberViewChartPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

