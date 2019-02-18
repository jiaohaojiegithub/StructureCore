using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SAnswer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public int? Testpaperid { get; set; }
        public int? Sumscore { get; set; }
        public int? Testtime { get; set; }
        public int? Istest { get; set; }
        public int? Ischeck { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
