using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SCategory
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Categoryname { get; set; }
        public int? Parentid { get; set; }
        public int? Type { get; set; }
        public string Cruid { get; set; }
        public string Permit { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
