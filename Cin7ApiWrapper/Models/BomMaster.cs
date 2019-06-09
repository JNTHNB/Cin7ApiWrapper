using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class BomMaster
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public string ProductionNotes { get; set; }
        public string Reference { get; set; }
        public Product Product { get; set; }
    }

    public class BomMaterProduct
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
        [JsonProperty(PropertyName = "Qty")]
        public decimal Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public List<BomMaterProductComponent> Components { get; set; }
    }

    public class BomMaterProductComponent
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
        [JsonProperty(PropertyName = "Qty")]
        public decimal Quantity { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
