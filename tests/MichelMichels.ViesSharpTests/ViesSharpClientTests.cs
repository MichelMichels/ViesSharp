using MichelMichels.ViesSharp.Exceptions;
using MichelMichels.ViesSharp.Models;
using System.Diagnostics;
using System.Text.Json;

namespace MichelMichels.ViesSharp.Tests;

[TestClass()]
public class ViesSharpClientTests
{
    [TestMethod()]
    public async Task Production_CheckStatus_Test()
    {
        // Arrange
        ViesSharpClient client = new();

        // Act
        StatusResponse response = await client.CheckStatus();

        // Assert
        Assert.IsNotNull(response);

        Debug.WriteLine(JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true }));
    }

    [TestMethod]
    [DataRow("0244142664")]
    public async Task Production_Belgium_CheckVatNumber_Test(string vatNumber)
    {
        // Arrange
        ViesSharpClient client = new();
        VatNumberRequest request = new()
        {
            CountryCode = "BE",
            VatNumber = vatNumber
        };

        // Act
        VatNumberResponse response = await client.CheckVatNumber(request);

        // Assert
        Assert.IsNotNull(response);
        Assert.AreEqual("BE", response.CountryCode);
        Assert.IsTrue(response.IsValid);

        Debug.WriteLine(JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true }));
    }

    [TestMethod]
    [DataRow("100", "VALID", true)]
    [DataRow("200", "INVALID", false)]
    public async Task Production_CheckVatTestService_Test(string vatNumber, string validity, bool isValid)
    {
        // Arrange
        ViesSharpClient client = new();
        VatNumberRequest request = new()
        {
            CountryCode = "BE",
            VatNumber = vatNumber
        };

        // Act
        VatNumberResponse response = await client.CheckVatTestService(request);

        // Assert
        Assert.IsNotNull(response);
        Assert.AreEqual(isValid, response.IsValid);

        Debug.WriteLine(JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true }));
    }

    [TestMethod]
    [Ignore] // Ignore this test because it requires a mock service to be running locally.
    public async Task Mock_CheckVatNumber_ErrorResponse_Test()
    {
        // Arrange
        ViesSharpClient client = new(new ViesSharpOptions
        {
            BaseUrl = "https://localhost:7238/"
        });

        VatNumberRequest request = new()
        {
            CountryCode = "BE",
            VatNumber = "0244142664"
        };

        // Act
        ViesSharpException exception = await Assert.ThrowsAsync<ViesSharpException>(() => client.CheckVatNumber(request));

        // Assert
        Assert.IsNotNull(exception.ErrorResponse);
    }
}