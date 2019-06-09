using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class ProductionJob
    {
        public ProductionJob()
        {
            Products = new List<ProductionJobProduct>();
        }

        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int CompletedBy { get; set; }
        public bool IsApproved { get; set; }
        public int BranchId { get; set; }
        public string ProjectName { get; set; }
        public string ProductionNotes { get; set; }
        public string Reference { get; set; }
        public string Source { get; set; }
        public decimal TotalCost { get; set; }
        public List<ProductionJobProduct> Products { get; set; }
    }

    public class ProductionJobProduct
    {
        public ProductionJobProduct()
        {
            Components = new List<ProductionJobComponent>();
        }

        public int Id { get; set; }
        [JsonProperty]
        public int ProductId { get; private set; }
        public int ProductOptionId { get; set; }
        public string Type { get; set; }
        public int Sort { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Notes { get; set; }
        public DateTime? DueDate { get; set; }
        [JsonProperty(PropertyName = "StandardQty")]
        public decimal StandardQuantity { get; set; }
        [JsonProperty(PropertyName = "ActualQty")]
        public decimal ActualQuantity { get; set; }
        public decimal UnitCost { get; set; }
        public List<ProductionJobComponent> Components { get; set; }
    }

    public class ProductionJobComponent
    {
        public int Id { get; set; }
        [JsonProperty]
        public int ProductId { get; private set; }
        public int ProductOptionId { get; set; }
        public string Type { get; set; }
        public int Sort { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Notes { get; set; }
        public DateTime? DueDate { get; set; }
        [JsonProperty(PropertyName = "StandardQty")]
        public decimal StandardQuantity { get; set; }
        [JsonProperty(PropertyName = "ActualQty")]
        public decimal ActualQuantity { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
