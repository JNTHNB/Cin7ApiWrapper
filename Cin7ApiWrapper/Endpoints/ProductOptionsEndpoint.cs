using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class ProductOptionsEndpoint : Cin7ReadEndpoint<ProductOptionsEndpoint, ProductOption>
    {
        internal ProductOptionsEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/ProductOptions")
        {

        }
    }
}
