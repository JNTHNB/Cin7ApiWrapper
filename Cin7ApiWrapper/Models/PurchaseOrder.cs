using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class PurchaseOrder
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
        public string Fax { get; set; }
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
        [JsonProperty]
        public decimal ProductTotal { get; private set; }
        public decimal FreightTotal { get; set; }
        public string FreightDescription { get; set; }
        public decimal Surcharge { get; set; }
        public string SurchargeDescription { get; set; }
        public decimal DiscountTotal { get; set; }
        public string DiscountDescription { get; set; }
        [JsonProperty]
        public decimal Total { get; private set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyRate { get; set; }
        public string CurrencySymbol { get; set; }
        public TaxStatus? TaxStatus { get; set; }
        public decimal? TaxRate { get; set; }
        public string Source { get; set; }
        public Dictionary<string, object> CustomFields { get; set; }
        public string MemberEmail { get; set; }
        public string MemberCostCenter { get; set; }
        public decimal? MemberAlternativeTaxRate { get; set; }
        public string CostCenter { get; set; }
        public decimal? AlternativeTaxRate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public int SalesPersonId { get; set; }
        public string SalesPersonEmail { get; set; }
        public string PaymentTerms { get; set; }
        public string CustomerOrderNo { get; set; }
        public string VoucherCode { get; set; }
        public string DeliveryInstructions { get; set; }
        [JsonProperty]
        public string Status { get; private set; }
        public string Stage { get; set; }
        public string SupplierInvoiceReference { get; set; }
        public DateTime? SupplierAcceptanceDate { get; set; }
        public string Port { get; set; }
        public DateTime? EstimatedArrivalDate { get; set; }
        public DateTime? FullyReceivedDate { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public List<PurchaseOrderLineitem> LineItems { get; set; }
    }

    public class PurchaseOrderLineitem
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
        public string StyleCode { get; set; }
        public string Barcode { get; set; }
        public string SizeCodes { get; set; }
        public string LineComments { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Discount { get; set; }
        [JsonProperty(PropertyName = "QtyShipped")]
        public decimal? QuantityShipped { get; private set; }
        [JsonProperty(PropertyName = "HoldingQty")]
        public decimal? HoldingQuantity { get; set; }
        public string AccountCode { get; set; }
    }

}
