using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public class ProductVariation
    {
        public int ProductId { get; set; }
        public int ProductOptionId { get; set; }

        public bool IsActive { get; set; }

        /// <summary>
        /// The product name. 
        /// </summary>
        public string Name { get; set; }
        public string StyleCode { get; set; }

        public string OptionLabel1 { get; set; }
        public string Option1 { get; set; }
        public string OptionLabel2 { get; set; }
        public string Option2 { get; set; }
        public string OptionLabel3 { get; set; }
        public string Option3 { get; set; }
        public string Size { get; set; }

        /// <summary>
        /// Returns the product name combined with a comma separated list of options.
        /// </summary>
        public string NameAndOptions
        {
            get
            {
                string str = Name;
                string options = null;

                if (!string.IsNullOrEmpty(StyleCode))
                    str = str + string.Format(" ({0})", StyleCode);

                if (!string.IsNullOrEmpty(Option1))
                    options = options + Option1 + ", ";

                if (!string.IsNullOrEmpty(Option2))
                    options = options + Option2 + ", ";

                if (!string.IsNullOrEmpty(Option3))
                    options = options + Option3 + ", ";

                if (options != null)
                    str = str + " - " + options.TrimEnd(new char[] { ',', ' ' });

                if (!string.IsNullOrEmpty(Size))
                    str = str + ", Size " + Size;

                return str;
            }
        }

        /// <summary>
        /// SKU
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// UPC
        /// </summary>
        public string Barcode { get; set; }
        /// <summary>
        /// Supplier Code
        /// </summary>
        public string SupplierCode { get; set; }
        /// <summary>
        /// The unit price. 
        /// </summary>
        public decimal? UnitPrice { get; set; }

        public decimal? SpecialPrice { get; set; }
        public DateTime? SpecialStart { get; set; }
        public int SpecialDays { get; set; }

        /// <summary>
        /// The date when the special price expires (i.e special start date + days).
        /// </summary>
        public DateTime? SpecialExpires
        {
            get
            {
                if (SpecialStart.HasValue)
                    return SpecialStart.Value.AddDays(SpecialDays);

                return SpecialStart;
            }
        }

        /// <summary>
        /// The unit cost.
        /// </summary>
        public decimal? UnitCost { get; set; }
        public decimal StockAvailable { get; set; }
        public decimal StockOnHand { get; set; }

        /// <summary>
        /// The full image URL on the Cin7 Server. 
        /// </summary>
        public Image Image { get; set; }
        public TaxStatus? TaxStatus { get; set; }
        public string XeroIncomeCode { get; set; }

        public Dictionary<string, decimal?> PriceColumns { get; set; }
    }
}
