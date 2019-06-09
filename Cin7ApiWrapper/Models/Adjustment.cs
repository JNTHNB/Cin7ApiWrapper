using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class Adjustment
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ProcessedBy { get; set; }
        public bool IsApproved { get; set; }
        public string Reference { get; set; }
        public int BranchId { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string AdjustInAccountingSystem { get; set; }
        public string AdjustmentReason { get; set; }
        public string AlternativeAccountCode { get; set; }
        [JsonProperty]
        public decimal ProductTotal { get; private set; }
        public string Source { get; set; }
        public List<AdjustmentLineitem> LineItems { get; set; }
    }

    public class AdjustmentLineitem
    {
        public int Id { get; set; }
        [JsonProperty]
        public int ProductId { get; private set; }
        public int ProductOptionId { get; set; }
        public string IntegrationRef { get; set; }
        public int Sort { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        [JsonProperty(PropertyName = "Qty")]
        public decimal Quantity { get; set; }
        [JsonProperty(PropertyName = "QtyAdjusted")]
        public decimal? QuantityAdjusted { get; set; }
        [JsonProperty(PropertyName = "HoldingQty")]
        public decimal? HoldingQuantity { get; set; }
        public string Account { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
