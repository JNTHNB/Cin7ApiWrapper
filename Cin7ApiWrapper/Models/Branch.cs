using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
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
        public string IntegrationRef { get; set; }
        public Dictionary<string, object> CustomFields { get; set; }
        public List<SecondaryContact> SecondaryContacts { get; set; }
        public string BranchType { get; set; }
        public string StockControlOptions { get; set; }
        [JsonProperty(PropertyName = "TaxStatus")]
        public string TaxType { get; set; }
        public string AccountNumber { get; set; }
        public List<Branchlocation> BranchLocations { get; set; }
    }

    public class Branchlocation
    {
        public string Zone { get; set; }
        public string[] Bins { get; set; }
    }

}
