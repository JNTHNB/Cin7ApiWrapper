using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Endpoints
{
    public class SalesOrdersEndpoint : Cin7Endpoint<SalesOrdersEndpoint, SalesOrder>
    {
        internal SalesOrdersEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/SalesOrders")
        {

        }

        public IEnumerable<SalesOrder> InvoiceNumbers(params int[] invoiceNumbers)
        {
            return Find(where: invoiceNumbers.JoinFormat(" or ", "invoicenumber={0}"));
        }

        public CreateResult Create(SalesOrder item, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Create(item);
        }

        public CreateBatchResult Create(IEnumerable<SalesOrder> items, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Create(items);
        }

        public UpdateResult Update(SalesOrder item, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Update(item);
        }

        public UpdateBatchResult Update(IEnumerable<SalesOrder> items, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Update(items);
        }
    }
}
