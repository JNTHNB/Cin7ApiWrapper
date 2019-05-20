using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Endpoints
{
    public class PurchaseOrdersEndpoint : Cin7Endpoint<PurchaseOrdersEndpoint, PurchaseOrder>
    {
        internal PurchaseOrdersEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/PurchaseOrders")
        {

        }

        public CreateResult Create(PurchaseOrder item, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Create(item);
        }

        public CreateBatchResult Create(IEnumerable<PurchaseOrder> items, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Create(items);
        }

        public UpdateResult Update(PurchaseOrder item, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Update(item);
        }

        public UpdateBatchResult Update(IEnumerable<PurchaseOrder> items, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Update(items);
        }
    }
}
