using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SCourse
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int? Type { get; set; }
        public string Permit { get; set; }
        public int? Categoryid { get; set; }
        public string Title { get; set; }
        public string Bgimg { get; set; }
        public string Videoimg { get; set; }
        public string Detail { get; set; }
        public string Duration { get; set; }
        public string Fileurl { get; set; }
        public int? Readnum { get; set; }
        public string Cruid { get; set; }
        public DateTime? Crdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Update { get; set; }
        public string Upuid { get; set; }
        public int? Status { get; set; }
    }
}
