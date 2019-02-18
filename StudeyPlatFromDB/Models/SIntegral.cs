using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SIntegral
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public int? Type { get; set; }
        public string Action { get; set; }
        public string Content { get; set; }
        public int? Relateid { get; set; }
        public int? Integral { get; set; }
        public string Remark { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
