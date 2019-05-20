using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class BranchTransfersEndpoint : Cin7ReadEndpoint<BranchTransfersEndpoint, BranchTransfer>
    {
        internal BranchTransfersEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/BranchTransfers")
        {

        }
    }
}
