namespace Structural.Proxy
{
    public class HttpServiceProxy : IHttpService
    {
        private readonly IHttpService _httpService;
        private readonly Dictionary<string, string> _cache;

        public HttpServiceProxy(IHttpService httpService)
        {
            _httpService = httpService;
            _cache = new Dictionary<string, string>();
        }

        public string Get(string url)
        {
            if (_cache.ContainsKey(url))
                return _cache[url];

            var response = _httpService.Get(url);

            _cache[url] = response;

            return response;
        }
    }
}
