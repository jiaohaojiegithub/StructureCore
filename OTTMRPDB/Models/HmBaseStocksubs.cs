using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseStocksubs
    {
        public int Id { get; set; }
        public string FabricCode { get; set; }
        public string SupplierColor { get; set; }
        public string Type { get; set; }
        public string StyleId { get; set; }
        public string NewstyleId { get; set; }
        public string RequestId { get; set; }
        public string NewrequestId { get; set; }
        public decimal? Num { get; set; }
        public DateTime? Crdate { get; set; }
        public string Uid { get; set; }
    }
}
