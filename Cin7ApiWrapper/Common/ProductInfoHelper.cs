using System.Net.Http.Headers;
using System.Reflection;

namespace Cin7ApiWrapper.Common
{
    internal class ProductInfoHelper
    {
        public static ProductInfoHeaderValue GetUserAgentHeaderValue()
        {
            var info = Assembly.GetExecutingAssembly().GetName();
            return new ProductInfoHeaderValue(new ProductHeaderValue(info.Name, info.Version.ToString()));
        }
    }
}
