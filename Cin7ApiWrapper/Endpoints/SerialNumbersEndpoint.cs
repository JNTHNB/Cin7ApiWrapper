using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class SerialNumbersEndpoint : Cin7ReadEndpoint<SerialNumbersEndpoint, SerialNumber>
    {
        internal SerialNumbersEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/SerialNumbers")
        {

        }
    }
}
