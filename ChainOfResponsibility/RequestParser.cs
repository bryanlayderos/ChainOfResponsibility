namespace ChainOfResponsibility
{
    public class RequestParser
    {
        private IBaseRequestHandler headChain;

        public RequestParser()
        {
           this.headChain = new XMLRequestHandler();

            this.headChain.SetNextChain(new JSONRequestHandler());
        }

        public void ProcessRequest(Request request)
        {
            this.headChain.Deserialize(request);
        }
    }
}