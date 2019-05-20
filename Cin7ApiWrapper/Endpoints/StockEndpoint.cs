using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class StockEndpoint : Cin7ReadEndpoint<StockEndpoint, StockUnit>
    {
        internal StockEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/Stock")
        {

        }
    }
}
