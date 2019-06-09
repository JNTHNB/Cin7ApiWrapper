using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class BranchTransfer
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ProcessedBy { get; set; }
        public int ApprovedBy { get; set; }
        public bool IsApproved { get; set; }
        public string Reference { get; set; }
        public string BranchEmail { get; set; }
        public string InternalComments { get; set; }
        [JsonProperty]
        public decimal ProductTotal { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string ProjectName { get; set; }
        public string TrackingCode { get; set; }
        public string Source { get; set; }
        public int SourceBranchId { get; set; }
        public int DestinationBranchId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public List<BranchTransferLineitem> LineItems { get; set; }
    }

    public class BranchTransferLineitem
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
        [JsonProperty(PropertyName = "QtyTransferred")]
        public int? QuantityTransferred { get; set; }
        public decimal? UnitCost { get; set; }
    }

}
