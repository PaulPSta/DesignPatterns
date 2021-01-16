using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var accessRights = new AccessRights();
            
            var webCaller = new WebCaller();
            var webCallerProxy = new WebCallerProxy(accessRights, webCaller);

            var response = webCallerProxy.GetResource("https://jsonplaceholder.typicode.com/posts").Result;
            Console.WriteLine(response);
        }
    }
}
