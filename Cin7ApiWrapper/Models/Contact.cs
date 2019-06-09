using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public string Type { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string IntegrationRef { get; set; }
        public string AccountNumber { get; set; }
        public int BillingId { get; set; }
        public string BillingCompany { get; set; }
        public string BillingEmail { get; set; }
        public string AccountsFirstName { get; set; }
        public string AccountsLastName { get; set; }
        public string AccountsPhone { get; set; }
        public string BillingCostCenter { get; set; }
        public string CostCenter { get; set; }
        public string PriceColumn { get; set; }
        public string PaymentTerms { get; set; }
        [JsonProperty(PropertyName = "TaxStatus")]
        public string TaxType { get; set; }
        public string TaxNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalCity { get; set; }
        public string PostalPostCode { get; set; }
        public string PostalState { get; set; }
        public string PostalCountry { get; set; }
        public string Notes { get; set; }
        public string Group { get; set; }
        public string SubGroup { get; set; }
        public Dictionary<string, object> CustomFields { get; set; }
        public List<SecondaryContact> SecondaryContacts { get; set; }
    }

    public class SecondaryContact
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
    }
}