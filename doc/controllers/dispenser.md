# Dispenser

```csharp
DispenserController dispenserController = client.DispenserController;
```

## Class Name

`DispenserController`

## Methods

* [Mdspes Scripts Dispenser Get GET](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-get-get)
* [Mdspes Scripts Dispenser View Prescription POST](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-view-prescription-post)
* [Mdspes Scripts Dispenser Amend Dispensed Item POST](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-amend-dispensed-item-post)
* [Mdspes Scripts Dispenser Reverse Dispensed Item POST](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-reverse-dispensed-item-post)
* [Mdspes Scripts Dispenser Manual Dispense POST](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-manual-dispense-post)
* [Mdspes Scripts Dispenser Initiate Dispense POST](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-initiate-dispense-post)
* [Mdspes Scripts Dispenser Terminate Dispense POST](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-terminate-dispense-post)
* [Mdspes Scripts Dispenser Electronic Dispense POST](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-electronic-dispense-post)
* [Mdspes Scripts Dispenser Resend Token POST](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-resend-token-post)
* [Mdspes Scripts Dispenser Disable Script POST](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-disable-script-post)
* [Mdspes Scripts Dispenser Enable Script POST](../../doc/controllers/dispenser.md#mdspes-scripts-dispenser-enable-script-post)


# Mdspes Scripts Dispenser Get GET

```csharp
MdspesScriptsDispenserGetGETAsync()
```

## Response Type

`Task<string>`

## Example Usage

```csharp
try
{
    string result = await dispenserController.MdspesScriptsDispenserGetGETAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Dispenser View Prescription POST

```csharp
MdspesScriptsDispenserViewPrescriptionPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await dispenserController.MdspesScriptsDispenserViewPrescriptionPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Dispenser Amend Dispensed Item POST

```csharp
MdspesScriptsDispenserAmendDispensedItemPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await dispenserController.MdspesScriptsDispenserAmendDispensedItemPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Dispenser Reverse Dispensed Item POST

```csharp
MdspesScriptsDispenserReverseDispensedItemPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await dispenserController.MdspesScriptsDispenserReverseDispensedItemPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Dispenser Manual Dispense POST

```csharp
MdspesScriptsDispenserManualDispensePOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await dispenserController.MdspesScriptsDispenserManualDispensePOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Dispenser Initiate Dispense POST

```csharp
MdspesScriptsDispenserInitiateDispensePOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await dispenserController.MdspesScriptsDispenserInitiateDispensePOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Dispenser Terminate Dispense POST

```csharp
MdspesScriptsDispenserTerminateDispensePOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await dispenserController.MdspesScriptsDispenserTerminateDispensePOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Dispenser Electronic Dispense POST

```csharp
MdspesScriptsDispenserElectronicDispensePOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await dispenserController.MdspesScriptsDispenserElectronicDispensePOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Dispenser Resend Token POST

```csharp
MdspesScriptsDispenserResendTokenPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await dispenserController.MdspesScriptsDispenserResendTokenPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Dispenser Disable Script POST

```csharp
MdspesScriptsDispenserDisableScriptPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await dispenserController.MdspesScriptsDispenserDisableScriptPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Mdspes Scripts Dispenser Enable Script POST

```csharp
MdspesScriptsDispenserEnableScriptPOSTAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await dispenserController.MdspesScriptsDispenserEnableScriptPOSTAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

