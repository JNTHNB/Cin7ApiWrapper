using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class BranchesEndpoint : Cin7Endpoint<BranchesEndpoint, Branch>
    {
        internal BranchesEndpoint(Cin7ApiClient client) 
            : base(client, "/api/v1/Branches")
        {

        }
    }
}
