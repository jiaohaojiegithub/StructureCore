using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrCrmOrderProduct
    {
        public string FOrderEntryId { get; set; }
        public string FOrderId { get; set; }
        public string FProductId { get; set; }
        public string FProductCode { get; set; }
        public string FProductName { get; set; }
        public string FUnitId { get; set; }
        public decimal? FQty { get; set; }
        public decimal? FPrice { get; set; }
        public decimal? FAmount { get; set; }
        public decimal? FTaxprice { get; set; }
        public decimal? FTaxRate { get; set; }
        public decimal? FTax { get; set; }
        public decimal? FTaxAmount { get; set; }
        public int? FSortCode { get; set; }
        public int? FDeleteMark { get; set; }
        public int? FEnabledMark { get; set; }
        public string FDescription { get; set; }
    }
}
