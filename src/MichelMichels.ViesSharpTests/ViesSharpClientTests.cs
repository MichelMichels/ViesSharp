using MichelMichels.ViesSharp.Models;
using System.Diagnostics;
using System.Text.Json;

namespace MichelMichels.ViesSharp.Tests;

[TestClass()]
public class ViesSharpClientTests
{
    [TestMethod()]
    public async Task CheckStatus()
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
    public async Task CheckVatNumber()
    {
        // Arrange
        ViesSharpClient client = new();
        VatNumberRequest request = new()
        {
            CountryCode = "BE",
            VatNumber = "0244142664"
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
    public async Task CheckVatTestService(string vatNumber, string validity, bool isValid)
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
}