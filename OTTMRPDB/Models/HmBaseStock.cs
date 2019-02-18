using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseStock
    {
        public int Id { get; set; }
        public string DepotId { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string FabricCode { get; set; }
        public string SupplierColor { get; set; }
        public decimal? Sjkcnum { get; set; }
        public decimal? Kpkcnum { get; set; }
        public int? Status { get; set; }
    }
}
