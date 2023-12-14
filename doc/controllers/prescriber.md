# Prescriber

```csharp
PrescriberController prescriberController = client.PrescriberController;
```

## Class Name

`PrescriberController`

## Methods

* [Mdspes Scripts Prescriber Upload Prescription POST](../../doc/controllers/prescriber.md#mdspes-scripts-prescriber-upload-prescription-post)
* [Mdspes Scripts Prescriber Cancel Prescription POST](../../doc/controllers/prescriber.md#mdspes-scripts-prescriber-cancel-prescription-post)
* [Mdspes Scripts Prescriber Get GET](../../doc/controllers/prescriber.md#mdspes-scripts-prescriber-get-get)
* [Mdspes Scripts Prescriber Cease Prescription POST](../../doc/controllers/prescriber.md#mdspes-scripts-prescriber-cease-prescription-post)
* [Mdspes Scripts Prescriber Resend Token POST](../../doc/controllers/prescriber.md#mdspes-scripts-prescriber-resend-token-post)


# Mdspes Scripts Prescriber Upload Prescription POST

```csharp
MdspesScriptsPrescriberUploadPrescriptionPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await prescriberController.MdspesScriptsPrescriberUploadPrescriptionPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Prescriber Cancel Prescription POST

```csharp
MdspesScriptsPrescriberCancelPrescriptionPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await prescriberController.MdspesScriptsPrescriberCancelPrescriptionPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Prescriber Get GET

```csharp
MdspesScriptsPrescriberGetGETAsync()
```

## Response Type

`Task<string>`

## Example Usage

```csharp
try
{
    string result = await prescriberController.MdspesScriptsPrescriberGetGETAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Prescriber Cease Prescription POST

```csharp
MdspesScriptsPrescriberCeasePrescriptionPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await prescriberController.MdspesScriptsPrescriberCeasePrescriptionPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Prescriber Resend Token POST

```csharp
MdspesScriptsPrescriberResendTokenPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await prescriberController.MdspesScriptsPrescriberResendTokenPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

