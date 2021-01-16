using System.Net.Http;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class WebCaller : IWebCaller
    {
        public async Task<string> GetResource(string url)
        {
            using var client = new HttpClient();

            var response = await client.GetAsync(url);

            return await response.Content.ReadAsStringAsync();
        }
    }
}