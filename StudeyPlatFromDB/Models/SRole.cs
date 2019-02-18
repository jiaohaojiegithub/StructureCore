using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SRole
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Rolename { get; set; }
        public int? Type { get; set; }
        public string Cruid { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
