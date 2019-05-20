using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ProcessedBy { get; set; }
        public bool IsApproved { get; set; }
        public string Reference { get; set; }
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string DeliveryFirstName { get; set; }
        public string DeliveryLastName { get; set; }
        public string DeliveryCompany { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryState { get; set; }
        public string DeliveryPostalCode { get; set; }
        public string DeliveryCountry { get; set; }
        public string BillingFirstName { get; set; }
        public string BillingLastName { get; set; }
        public string BillingCompany { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public int BranchId { get; set; }
        public string BranchEmail { get; set; }
        public string ProjectName { get; set; }
        public string TrackingCode { get; set; }
        public string InternalComments { get; set; }
        public decimal ProductTotal { get; set; }
        public decimal FreightTotal { get; set; }
        public string FreightDescription { get; set; }
        public decimal Surcharge { get; set; }
        public string SurchargeDescription { get; set; }
        public decimal DiscountTotal { get; set; }
        public string DiscountDescription { get; set; }
        public decimal Total { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyRate { get; set; }
        public string CurrencySymbol { get; set; }
        public TaxStatus TaxStatus { get; set; }
        public decimal TaxRate { get; set; }
        public string Source { get; set; }
        public Dictionary<string, object> CustomFields { get; set; }
        public string MemberEmail { get; set; }
        public string MemberCostCenter { get; set; }
        public decimal MemberAlternativeTaxRate { get; set; }
        public string CostCenter { get; set; }
        public decimal AlternativeTaxRate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public int SalesPersonId { get; set; }
        public string SalesPersonEmail { get; set; }
        public string PaymentTerms { get; set; }
        public string CustomerOrderNo { get; set; }
        public string VoucherCode { get; set; }
        public string DeliveryInstructions { get; set; }
        public string Status { get; set; }
        public string Stage { get; set; }
        public decimal Probability { get; set; }
        public DateTime? ExpectedOrderDate { get; set; }
        public DateTime? AcceptanceDate { get; set; }
        public IEnumerable<QuoteLineitem> LineItems { get; set; }
    }

    public class QuoteLineitem
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
        public string StyleCode { get; set; }
        public string Barcode { get; set; }
        public string SizeCodes { get; set; }
        public string LineComments { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal QtyShipped { get; set; }
        public decimal HoldingQty { get; set; }
    }

}
