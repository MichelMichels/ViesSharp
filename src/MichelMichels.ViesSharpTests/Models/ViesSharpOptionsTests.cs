using MichelMichels.ViesSharp;

namespace MichelMichels.ViesSharpTests.Models;

[TestClass]
public class ViesSharpOptionsTests
{
    [TestMethod]
    public void BaseUrl_NotNull()
    {
        // Arrange
        ViesSharpOptions options = new();

        // Act 

        // Assert
        Assert.IsNotNull(options.BaseUrl);
    }

    [TestMethod]
    public void BaseUrl_DefaultValue()
    {
        // Arrange
        ViesSharpOptions options = new();

        // Act 

        // Assert
        Assert.AreEqual("https://ec.europa.eu/taxation_customs/vies/rest-api/", options.BaseUrl);
    }
}
