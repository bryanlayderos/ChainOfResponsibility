namespace ChainOfResponsibility
{
    using System;

    public class XMLRequestHandler : IBaseRequestHandler
    {
        private readonly string contentType = "XML";

        private IBaseRequestHandler nextChain;

        public void SetNextChain(IBaseRequestHandler handler)
        {
            this.nextChain = handler;
        }

        public void Deserialize(Request request)
        {
            if (request.ContentType.Equals(this.contentType))
            {
                Console.WriteLine("Content-type: " + request.ContentType);
                Console.WriteLine("Content: " + request.Content + "\n");
            }
            else
            {
                this.nextChain.Deserialize(request);
            }
        }
    }
}