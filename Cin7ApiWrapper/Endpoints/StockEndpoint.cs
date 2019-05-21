using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Endpoints
{
    public class StockEndpoint : Cin7ReadEndpoint<StockEndpoint, StockUnit>
    {
        internal StockEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/Stock")
        {

        }

        public IEnumerable<StockUnit> ForBranchId(int branchId)
        {
            return Find(where: $"branchId={branchId}");
        }

        /// <summary>
        /// Find Stock for a Code (SKU)
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public IEnumerable<StockUnit> ForCode(string code)
        {
            return Find(where: $"code='{code}'");
        }

        /// <summary>
        /// Find Stock for a Barcode (UPC)
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public IEnumerable<StockUnit> ForBarcode(string barcode)
        {
            return Find(where: $"barcode='{barcode}'");
        }

    }
}
