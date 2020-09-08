namespace ChainOfResponsibility
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Request xmlRequest = new Request("XML", "This request contains XML content.");
            Request jsonRequest = new Request("JSON", "This request contains JSON content.");
            Request htmlRequest = new Request("HTML", "This request contains HTML content.");

            RequestParser requestParser = new RequestParser();

            requestParser.ProcessRequest(xmlRequest);
            requestParser.ProcessRequest(jsonRequest);
            requestParser.ProcessRequest(htmlRequest);

            Console.ReadLine();
        }
    }
}