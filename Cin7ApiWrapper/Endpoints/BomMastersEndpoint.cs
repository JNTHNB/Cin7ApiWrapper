using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class BomMastersEndpoint : Cin7ReadEndpoint<BomMastersEndpoint, BomMaster>
    {
        internal BomMastersEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/BomMasters")
        {

        }
    }
}
