using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBaseOutStoresub
    {
        public int Id { get; set; }
        public string OutStoreId { get; set; }
        public int? InStoresubId { get; set; }
        public string FabricCode { get; set; }
        public string ColorId { get; set; }
        public string SupplierColor { get; set; }
        public string Specification { get; set; }
        public string StyleId { get; set; }
        public decimal? Num { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? Sum { get; set; }
        public int? Status { get; set; }
    }
}
