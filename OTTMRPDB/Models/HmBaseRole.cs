using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseRole
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string RoleName { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
    }
}
