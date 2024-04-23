# 🛂 ViesSharp

[![NuGet Version](https://img.shields.io/nuget/v/MichelMichels.ViesSharp)](https://www.nuget.org/packages/MichelMichels.ViesSharp)
[![.NET](https://github.com/MichelMichels/ViesSharp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/MichelMichels/ViesSharp/actions/workflows/dotnet.yml)

This projects is a C# wrapper library to [validate VAT numbers with VIES]("https://ec.europa.eu/taxation_customs/vies/#/vat-validation").

<details>
<summary>Table of Contents</summary>

- [🛂 ViesSharp](#-viessharp)
  - [Prerequisites](#prerequisites)
  - [Building](#building)
  - [Installation](#installation)
  - [Getting started](#getting-started)
  - [Usage](#usage)
    - [Check VAT number](#check-vat-number)
    - [Check VAT test service](#check-vat-test-service)
    - [Check status](#check-status)
    - [Exceptions](#exceptions)
  - [Credits](#credits)

</details>

---

## Prerequisites
- [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

## Building

Use [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) to build the project. 

## Installation

Get the NuGet packages from [nuget.org](https://www.nuget.org/) or search for `MichelMichels.ViesSharp` in the GUI package manager in Visual Studio.

You can also use the cli of the package manager with following command:

```cli
Install-Package MichelMichels.ViesSharp
```
<br />
<hr>

## Getting started

This repository contains 2 projects:
- `MichelMichels.ViesSharp` - Core library
- `MichelMichels.ViesSharpTests` - Testing library

## Usage

There are only 3 REST calls on this API. You can find for each call example code below.

### Check VAT number 

This code below checks the VAT number for the Belgian national broadcasting company (VRT):

```csharp
IViesSharpClient client = new ViesSharpClient();
VatNumberRequest request = new()
{
    CountryCode = "BE",
    VatNumber = "0244142664"
};

VatNumberResponse response = await client.CheckVatNumber(request);
```

Response:
```json
{
  "countryCode": "BE",
  "vatNumber": "0244142664",
  "requestDate": "2024-04-23T08:04:10.919Z",
  "valid": true,
  "requestIdentifier": "",
  "name": "NV OR De Vlaamse Radio- en Televisieomroeporganisatie",
  "address": "Auguste Reyerslaan 52\n1030 Schaarbeek",
  "traderName": "---",
  "traderStreet": "---",
  "traderPostalCode": "---",
  "traderCity": "---",
  "traderCompanyType": "---",
  "traderNameMatch": "NOT_PROCESSED",
  "traderStreetMatch": "NOT_PROCESSED",
  "traderPostalCodeMatch": "NOT_PROCESSED",
  "traderCityMatch": "NOT_PROCESSED",
  "traderCompanyTypeMatch": "NOT_PROCESSED"
}
```

### Check VAT test service

This call can be used to test the VAT service with example VatNumbers `100` and `200`.
See the `ViesSharpClientTests.CheckVatTestService()` method in the test library for more information.

### Check status

This call can be used to verify if the service is active and which countries are supported.

```csharp
IViesSharpClient client = new ViesSharpClient();
StatusResponse response = await client.CheckStatus();
```

### Exceptions

This library throws `ViesSharpException`s if the HTTP status code is not 200. This `ViesSharpException` has a property `ErrorResponse` with a deserialized error response of the VIES service to indicate what is wrong with the call.

## Credits

Written by [Michel Michels](https://github.com/MichelMichels).
