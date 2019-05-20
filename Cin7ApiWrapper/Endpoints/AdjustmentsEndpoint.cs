using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class AdjustmentsEndpoint : Cin7ReadEndpoint<AdjustmentsEndpoint, Adjustment>
    {
        internal AdjustmentsEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/Adjustments")
        {

        }
    }
}
