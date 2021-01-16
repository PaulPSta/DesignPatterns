using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface IWebCaller
    { 
        Task<string> GetResource(string url);
    }
}