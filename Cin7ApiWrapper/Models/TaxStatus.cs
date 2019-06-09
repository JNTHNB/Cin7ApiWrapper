using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Cin7ApiWrapper.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxStatus
    {
        [EnumMember(Value = "Incl")]
        Including,
        [EnumMember(Value = "Excl")]
        Excluding,
        [EnumMember(Value = "Exempt")]
        Exempt
    }
}
