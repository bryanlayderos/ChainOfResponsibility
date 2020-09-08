namespace ChainOfResponsibility
{
    public interface IBaseRequestHandler
    {
        void SetNextChain(IBaseRequestHandler handler);

        void Deserialize(Request request);
    }
}