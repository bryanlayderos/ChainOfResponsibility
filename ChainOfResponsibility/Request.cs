namespace ChainOfResponsibility
{
    public class Request
    {
        public Request(string contentType, string content)
        {
            this.ContentType = contentType;
            this.Content = content;
        }

        public string ContentType { get; set; }

        public string Content { get; set; }
    }
}