using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBaseManager
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int? RoleId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
        public string RoleIds { get; set; }
        public string SupplierCode { get; set; }
    }
}
