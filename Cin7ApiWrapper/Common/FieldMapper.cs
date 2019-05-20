using Newtonsoft.Json.Serialization;
using System;
using System.Linq;

namespace Cin7ApiWrapper.Common
{
    internal class FieldMapper
    {
        public static string GetFields(Type type)
        {
            var resolver = new CamelCasePropertyNamesContractResolver();
            var contract = (JsonObjectContract)resolver.ResolveContract(type);
            return string.Join(",", contract.Properties.Select(p => p.PropertyName));
        }
    }
}
