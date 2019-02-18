using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class STestPaper
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public string Bgimg { get; set; }
        public string Remark { get; set; }
        public int? Papertime { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Isend { get; set; }
        public int? Isaward { get; set; }
        public int? Categoryid { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
