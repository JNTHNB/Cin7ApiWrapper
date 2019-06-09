using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;
using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Endpoints
{
    public class ProductsEndpoint : Cin7ReadEndpoint<ProductsEndpoint, Product>
    {
        const string _endpoint = "/api/v1/Products";

        internal ProductsEndpoint(Cin7ApiClient client)
            : base(client, _endpoint)
        {

        }
    }

    public static class ProductsEndpointExtensions
    {
        public static IEnumerable<ProductVariation> Flatten(this IEnumerable<Product> list)
        {
            foreach (var product in list)
            {
                foreach (var option in product.ProductOptions)
                {
                    yield return new ProductVariation()
                    {
                        ProductId = product.Id,
                        ProductOptionId = option.Id,
                        Name = product.Name,
                        StyleCode = product.StyleCode,
                        OptionLabel1 = product.OptionLabel1,
                        OptionLabel2 = product.OptionLabel2,
                        OptionLabel3 = product.OptionLabel3,
                        Option1 = option.Option1,
                        Option2 = option.Option2,
                        Option3 = option.Option3,
                        Size = option.Size,
                        Code = option.Code,
                        Barcode = option.Barcode,
                        UnitPrice = option.RetailPrice,
                        StockAvailable = option.StockAvailable,
                        StockOnHand = option.StockOnHand,
                        Image = option.Image
                    };
                }
            }
        }
    }
}
