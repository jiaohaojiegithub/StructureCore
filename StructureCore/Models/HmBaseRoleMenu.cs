using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBaseRoleMenu
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
        public int? Type { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
    }
}
