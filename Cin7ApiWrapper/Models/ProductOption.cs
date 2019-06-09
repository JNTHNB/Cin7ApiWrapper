using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class ProductOption
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Status { get; set; }
        public int ProductId { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public string SupplierCode { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public decimal OptionWeight { get; set; }
        public string Size { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? WholesalePrice { get; set; }
        public decimal? VipPrice { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTime? SpecialStartDate { get; set; }
        public int? SpecialDays { get; set; }
        public decimal StockAvailable { get; set; }
        public decimal StockOnHand { get; set; }
        public Image Image { get; set; }
        public Dictionary<string, object> PriceColumns { get; set; }
    }
}
