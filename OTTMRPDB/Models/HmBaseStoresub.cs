using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseStoresub
    {
        public int Id { get; set; }
        public int? StoreId { get; set; }
        public string FabricCode { get; set; }
        public string SupplierColor { get; set; }
        public string ColorId { get; set; }
        public string Specification { get; set; }
        public string StyleId { get; set; }
        public decimal? Rknum { get; set; }
        public decimal? Cknum { get; set; }
        public decimal? Sum { get; set; }
        public string Comment { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string RequestId { get; set; }
        public int? UseStatus { get; set; }
    }
}
