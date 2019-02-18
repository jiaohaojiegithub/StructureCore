using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBaseInStoresub
    {
        public int Id { get; set; }
        public string InStoreId { get; set; }
        public string RequestId { get; set; }
        public int? ReceivesubId { get; set; }
        public string FabricCode { get; set; }
        public string ColorId { get; set; }
        public string SupplierColor { get; set; }
        public string Specification { get; set; }
        public string StyleId { get; set; }
        public int? Shnum { get; set; }
        public decimal? Num { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? Sum { get; set; }
        public int? Status { get; set; }
    }
}
