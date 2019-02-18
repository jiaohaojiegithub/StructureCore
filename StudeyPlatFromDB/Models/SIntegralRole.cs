using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SIntegralRole
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Rolename { get; set; }
        public int? Integral { get; set; }
        public string Remark { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
