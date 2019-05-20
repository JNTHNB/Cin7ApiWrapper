using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class VouchersEndpoint : Cin7ReadEndpoint<VouchersEndpoint, Voucher>
    {
        internal VouchersEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/Voucher")
        {

        }
    }
}
