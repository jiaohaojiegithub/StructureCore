using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseStore
    {
        public int Id { get; set; }
        public string DepotId { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string FabricCode { get; set; }
        public string SupplierColor { get; set; }
        public string ColorId { get; set; }
        public string Specification { get; set; }
        public string StyleId { get; set; }
        public decimal? Rknum { get; set; }
        public decimal? Cknum { get; set; }
        public decimal? Sum { get; set; }
        public int? Status { get; set; }
    }
}
