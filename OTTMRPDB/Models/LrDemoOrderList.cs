using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrDemoOrderList
    {
        public string Id { get; set; }
        public string UId { get; set; }
        public string MeterialId { get; set; }
        public string MeterialName { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
    }
}
