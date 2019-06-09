using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string StyleCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PdfUpload { get; set; }
        public string PdfDescription { get; set; }
        public int SupplierId { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int[] CategoryIdArray { get; set; }
        public string Channels { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal Volume { get; set; }
        public string StockControl { get; set; }
        public string OrderType { get; set; }
        public string ProductType { get; set; }
        public string ProjectName { get; set; }
        public string OptionLabel1 { get; set; }
        public string OptionLabel2 { get; set; }
        public string OptionLabel3 { get; set; }
        public Dictionary<string, object> CustomFields { get; set; }
        public List<ProductOption> ProductOptions { get; set; }
    }
}
