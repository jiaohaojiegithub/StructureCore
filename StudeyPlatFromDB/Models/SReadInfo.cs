using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SReadInfo
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public int? Courseid { get; set; }
        public int? Readtime { get; set; }
        public int? Times { get; set; }
        public DateTime? Crdate { get; set; }
        public DateTime? Lastdate { get; set; }
        public int? Status { get; set; }
    }
}
