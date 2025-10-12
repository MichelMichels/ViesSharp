using MichelMichels.ViesSharp.Models;

namespace MichelMichels.ViesSharpTests.Models;

[TestClass]
public class CountryTests
{
    [TestMethod]
    public void DefaultValues()
    {
        // Arrange
        Country country = new();

        // Act

        // Assert
        Assert.IsNotNull(country.Availability);
        Assert.IsNotNull(country.CountryCode);
        Assert.AreEqual(string.Empty, country.Availability);
        Assert.AreEqual(string.Empty, country.CountryCode);
    }
}
