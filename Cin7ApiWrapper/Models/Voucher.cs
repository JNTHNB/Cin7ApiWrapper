using System;

namespace Cin7ApiWrapper.Models
{
    public class Voucher
    {
        public DateTime? CreatedDate { get; set; }
        public string Status { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        public int RedeemedCount { get; set; }
        public int RedeemedCountLimit { get; set; }
        public decimal RedeemedAmount { get; set; }
    }
}