using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseOutStore
    {
        public int Id { get; set; }
        public string OutStoreId { get; set; }
        public string InStoreId { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string FabricCode { get; set; }
        public string StyleId { get; set; }
        public decimal? Num { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? Sum { get; set; }
        public string UseName { get; set; }
        public string SupplierColor { get; set; }
        public string Comment { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string OutStoreUser { get; set; }
        public DateTime? OutStoreDate { get; set; }
        public int? Step { get; set; }
        public int? Status { get; set; }
        public int? TechnicianId { get; set; }
        public string RequestId { get; set; }
        public string Master { get; set; }
        public string Designer { get; set; }
    }
}
