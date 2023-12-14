# Error

```csharp
ErrorController errorController = client.ErrorController;
```

## Class Name

`ErrorController`

## Methods

* [Error Local Development GET](../../doc/controllers/error.md#error-local-development-get)
* [Error GET](../../doc/controllers/error.md#error-get)


# Error Local Development GET

```csharp
ErrorLocalDevelopmentGETAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await errorController.ErrorLocalDevelopmentGETAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Error GET

```csharp
ErrorGETAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await errorController.ErrorGETAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

