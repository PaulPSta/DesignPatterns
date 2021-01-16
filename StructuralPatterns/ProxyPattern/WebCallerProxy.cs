using System;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class WebCallerProxy : IWebCaller
    {
        private readonly IAccessRights _accessRights;
        private readonly IWebCaller _webCaller;

        public WebCallerProxy(IAccessRights accessRights, IWebCaller webCaller)
        {
            _accessRights = accessRights;
            _webCaller = webCaller;
        }

        public async Task<string> GetResource(string url)
        {
            if (_accessRights.DoesAUserHaveRightsToRetrieveResources())
                return await _webCaller.GetResource(url);

            throw new Exception("You don't have sufficient rights to access that resource.");
        }
    }
}