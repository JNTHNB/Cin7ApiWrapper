using System.Reflection;

namespace Cin7ApiWrapper.Common
{
    internal class ProductInfo
    {
        public string Name { get; }
        public string Version { get; }

        ProductInfo(string name, string version)
        {
            Name = name;
            Version = version;
        }

        public static ProductInfo GetProductInfo()
        {
            var product = Assembly.GetExecutingAssembly().GetName();
            return new ProductInfo(product.Name, product.Version.ToString());
        }
    }
}
