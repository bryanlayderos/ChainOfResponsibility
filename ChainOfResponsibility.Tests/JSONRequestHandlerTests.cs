namespace ChainOfResponsibility.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class JSONRequestHandlerTests
    {
        private readonly Mock<ILogger> debugLoggerMock = new Mock<ILogger>();

        [TestMethod]
        public void Deserialize_IfContentTypeIsJSON_LogContentType()
        {
            // Arrange
            string expectedOutput = "Content-type: JSON";
            Request request = new Request("JSON", "This is an JSON content");
            IBaseRequestHandler handlerRequest = new JSONRequestHandler();

            // Act
            handlerRequest.Deserialize(request, debugLoggerMock.Object);

            // Assert
            debugLoggerMock.Verify(x => x.Log(expectedOutput));
        }
    }
}
