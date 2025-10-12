using MichelMichels.ViesSharp.Models;

namespace MichelMichels.ViesSharpTests.Models;

[TestClass]
public class StatusResponseTests
{
    [TestMethod]
    public void DefaultValues()
    {
        // Arrange
        StatusResponse response = new();

        // Act

        // Assert
        Assert.IsNull(response.Vow);
        Assert.IsNotNull(response.Countries);
    }
}
