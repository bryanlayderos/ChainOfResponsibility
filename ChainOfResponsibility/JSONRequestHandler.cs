namespace ChainOfResponsibility
{
    using System;

    public class JSONRequestHandler : IBaseRequestHandler
    {
        private readonly string contentType = "JSON";

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
                Console.WriteLine("The content type of this request is not valid." + "\n");
            }
        }
    }
}