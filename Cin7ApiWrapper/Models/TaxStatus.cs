using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cin7ApiWrapper.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxStatus
    {
        Incl,
        Excl,
        Exempt
    }
}