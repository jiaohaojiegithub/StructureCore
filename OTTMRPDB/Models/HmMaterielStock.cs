using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmMaterielStock
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string DepotId { get; set; }
        public string MaterialCode { get; set; }
        public string StyleId { get; set; }
        public string CompanyColorId { get; set; }
        public string SupplierColorId { get; set; }
        public string Size { get; set; }
        public double? KNum { get; set; }
        public double? PNum { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUser { get; set; }
    }
}
