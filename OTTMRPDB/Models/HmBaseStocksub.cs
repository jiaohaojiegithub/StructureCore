using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseStocksub
    {
        public int Id { get; set; }
        public string DepotId { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string RequestId { get; set; }
        public string StyleId { get; set; }
        public string FabricCode { get; set; }
        public string SupplierColor { get; set; }
        public decimal? Rknum { get; set; }
        public decimal? Cknum { get; set; }
        public decimal? Sfnum { get; set; }
        public decimal? Innum { get; set; }
        public decimal? Outnum { get; set; }
        public string RelateId { get; set; }
        public int? Status { get; set; }
    }
}
