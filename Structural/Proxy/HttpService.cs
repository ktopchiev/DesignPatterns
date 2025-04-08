namespace Structural.Proxy
{
    public class HttpService : IHttpService
    {
        public string Get(string url)
        {
            Console.WriteLine("Fetching data from: " + url);
            var response = "Data fetched successfuly!";
            return response;
        }
    }
}
