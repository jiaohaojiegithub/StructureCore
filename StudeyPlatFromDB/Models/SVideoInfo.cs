using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SVideoInfo
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public int? Courseid { get; set; }
        public string Videoname { get; set; }
        public int? Sumwatchtime { get; set; }
        public int? Times { get; set; }
        public int? Iswatchsure { get; set; }
        public DateTime? Crdate { get; set; }
        public DateTime? Lastdate { get; set; }
        public int? Status { get; set; }
    }
}
