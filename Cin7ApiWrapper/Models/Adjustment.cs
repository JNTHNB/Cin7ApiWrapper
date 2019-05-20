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
        public decimal ProductTotal { get; set; }
        public string Source { get; set; }
        public IEnumerable<AdjustmentLineitem> LineItems { get; set; }
    }

    public class AdjustmentLineitem
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int ProductId { get; set; }
        public int ProductOptionId { get; set; }
        public string IntegrationRef { get; set; }
        public int Sort { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public decimal Qty { get; set; }
        public decimal QtyAdjusted { get; set; }
        public decimal HoldingQty { get; set; }
        public string Account { get; set; }
        public decimal UnitCost { get; set; }
    }

}
