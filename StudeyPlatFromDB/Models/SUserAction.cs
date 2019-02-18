using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SUserAction
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public string Url { get; set; }
        public string Pagename { get; set; }
        public string Telversion { get; set; }
        public DateTime? Startdate { get; set; }
        public int? Elapsedtime { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
