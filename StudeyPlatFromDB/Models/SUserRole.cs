using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SUserRole
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public string Roleid { get; set; }
        public int? Type { get; set; }
        public string Cruid { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
