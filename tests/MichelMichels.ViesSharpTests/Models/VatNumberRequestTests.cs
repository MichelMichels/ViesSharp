using MichelMichels.ViesSharp.Models;

namespace MichelMichels.ViesSharpTests.Models;

[TestClass]
public class VatNumberRequestTests
{
    [TestMethod]
    public void DefaultValues()
    {
        // Arrange
        VatNumberRequest request = new();

        // Act

        // Assert
        Assert.IsNotNull(request.CountryCode);
        Assert.IsNotNull(request.VatNumber);
        Assert.IsNotNull(request.RequesterMemberStateCode);
        Assert.IsNotNull(request.RequesterNumber);
        Assert.IsNotNull(request.TraderName);
        Assert.IsNotNull(request.TraderStreet);
        Assert.IsNotNull(request.TraderPostalCode);
        Assert.IsNotNull(request.TraderCity);
        Assert.IsNotNull(request.TraderCompanyType);
    }
}
