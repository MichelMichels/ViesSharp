using MichelMichels.ViesSharp.Models;

namespace MichelMichels.ViesSharpTests.Models;

[TestClass]
public class ErrorResponseTests
{
    [TestMethod]
    public void DefaultValues()
    {
        // Arrange
        ErrorResponse response = new();

        // Act

        // Assert
        Assert.IsNotNull(response.ErrorWrappers);
    }
}
