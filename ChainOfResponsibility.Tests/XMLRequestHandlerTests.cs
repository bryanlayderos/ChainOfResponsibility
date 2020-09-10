namespace ChainOfResponsibility.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class XMLRequestHandlerTests
    {
        private readonly Mock<ILogger> debugLoggerMock = new Mock<ILogger>();

        [TestMethod]
        public void Deserialize_IfContentTypeIsXML_LogContentType()
        {
            // Arrange
            string expectedOutput = "Content-type: XML";
            Request request = new Request("XML", "This is an XML content");
            IBaseRequestHandler handlerRequest = new XMLRequestHandler();

            // Act
            handlerRequest.Deserialize(request, debugLoggerMock.Object);

            // Assert
            debugLoggerMock.Verify(x => x.Log(expectedOutput));
        }
    }
}
