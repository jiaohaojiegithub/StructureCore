using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseUserRole
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public int? RoleId { get; set; }
        public int? Type { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? IsSure { get; set; }
        public int? Status { get; set; }
    }
}
