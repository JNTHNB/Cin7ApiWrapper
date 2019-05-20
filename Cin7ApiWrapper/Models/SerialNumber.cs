namespace Cin7ApiWrapper.Models
{
    public class SerialNumber
    {
        public int Id { get; set; }
        public string Serialnumber { get; set; }
        public int ProductId { get; set; }
        public int ProductOptionId { get; set; }
        public string Code { get; set; }
        public string HoldingGroup { get; set; }
        public int BranchId { get; set; }
        public decimal Available { get; set; }
    }
}

