using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBaseSupplier
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Linkman { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public int? Status { get; set; }
    }
}
