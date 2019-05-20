using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class StockUnitBatch
    {
        public List<StockUnit> Batch { get; set; }
    }

    public class StockUnit
    {
        public DateTime? LastModified { get; set; }
        public int ProductId { get; set; }
        public string StyleCode { get; set; }
        /// <summary>
        /// SKU
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// UPC
        /// </summary>
        public string Barcode { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string ProductName { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Size { get; set; }
        public decimal Available { get; set; }
        public decimal StockOnHand { get; set; }
        public decimal OpenSales { get; set; }
        public decimal IncomingStock { get; set; }
        public decimal VirtualStock { get; set; }
    }
}