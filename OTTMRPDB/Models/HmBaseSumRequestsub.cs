using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseSumRequestsub
    {
        public int Id { get; set; }
        public string SumRequestId { get; set; }
        public int? RequestId { get; set; }
        public string FabricCode { get; set; }
        public string ColorId { get; set; }
        public string SupplierColor { get; set; }
        public string Specification { get; set; }
        public string StyleId { get; set; }
        public decimal? Num { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? Sum { get; set; }
        public string RequestUser { get; set; }
        public DateTime? RequestDate { get; set; }
        public string Comment { get; set; }
        public int? Status { get; set; }
    }
}
