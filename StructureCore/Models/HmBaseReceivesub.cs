using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBaseReceivesub
    {
        public int Id { get; set; }
        public string ReceiveId { get; set; }
        public int? SupplierSuresubId { get; set; }
        public string FabricCode { get; set; }
        public string ColorId { get; set; }
        public string SupplierColor { get; set; }
        public string Specification { get; set; }
        public string StyleId { get; set; }
        public int? Fhnum { get; set; }
        public decimal? Num { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? Sum { get; set; }
        public int? FeelIsRight { get; set; }
        public int? ColorIsRight { get; set; }
        public int? Status { get; set; }
    }
}
