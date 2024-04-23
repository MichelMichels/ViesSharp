using MichelMichels.ViesSharp.Models;

namespace MichelMichels.ViesSharpTests.Models;

[TestClass]
public class ErrorWrapperTests
{
    [TestMethod]
    public void DefaultValues()
    {
        // Arrange
        ErrorWrapper wrapper = new();

        // Act

        // Assert
        Assert.IsNotNull(wrapper.Message);
        Assert.IsNotNull(wrapper.Error);
        Assert.AreEqual(string.Empty, wrapper.Message);
        Assert.AreEqual(string.Empty, wrapper.Error);
    }
}
