using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class ProductCategoriesEndpoint : Cin7ReadEndpoint<ProductCategoriesEndpoint, ProductCategory>
    {
        internal ProductCategoriesEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/ProductCategories")
        {

        }
    }
}
