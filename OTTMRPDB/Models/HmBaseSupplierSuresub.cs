using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseSupplierSuresub
    {
        public int Id { get; set; }
        public string SupplierSureId { get; set; }
        public int? PurchaseOrdersubId { get; set; }
        public string FabricCode { get; set; }
        public string ColorId { get; set; }
        public string SupplierColor { get; set; }
        public string Specification { get; set; }
        public string StyleId { get; set; }
        public decimal? Num { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? Sum { get; set; }
        public int? FeelIsRight { get; set; }
        public int? ColorIsRight { get; set; }
        public int? Status { get; set; }
    }
}
