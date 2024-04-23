using MichelMichels.ViesSharp.Models;

namespace MichelMichels.ViesSharpTests.Models;

[TestClass]
public class VatNumberResponseTests
{
    [TestMethod]
    public void DefaultValues()
    {
        // Arrange
        VatNumberResponse response = new();

        // Act

        // Assert
        Assert.IsNotNull(response.CountryCode);
        Assert.IsNotNull(response.Name);
        Assert.IsNotNull(response.TraderName);
        Assert.IsNotNull(response.TraderPostalCode);
        Assert.IsNotNull(response.TraderCity);
        Assert.IsNotNull(response.TraderCityMatch);
        Assert.IsNotNull(response.TraderCompanyType);
        Assert.IsNotNull(response.TraderCompanyTypeMatch);
        Assert.IsNotNull(response.TraderNameMatch);
        Assert.IsNotNull(response.TraderPostalCodeMatch);
        Assert.IsNotNull(response.VatNumber);
        Assert.IsNotNull(response.Address);
        Assert.IsNotNull(response.RequestIdentifier);
        Assert.IsNull(response.RequestDate);
    }
}
