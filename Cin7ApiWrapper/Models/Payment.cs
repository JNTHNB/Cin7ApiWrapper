using System;

namespace Cin7ApiWrapper.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string Method { get; set; }
        public bool IsAuthorized { get; set; }
        public string TransactionRef { get; set; }
        public string Comments { get; set; }
        public int OrderId { get; set; }
        public string OrderRef { get; set; }
        public string PaymentImportedRef { get; set; }
        public DateTime? ReconcileDate { get; set; }
        public int BranchId { get; set; }
        public string OrderType { get; set; }
    }

}
