using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Endpoints
{
    public class PaymentsEndpoint : Cin7Endpoint<PaymentsEndpoint, Payment>
    {
        internal PaymentsEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/Payments")
        {

        }

        public IEnumerable<Payment> ForSalesOrderId(int salesorderId)
        {
            return Find(where: $"orderId={salesorderId}");
        }
    }
}
