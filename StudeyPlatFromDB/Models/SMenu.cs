using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SMenu
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int? Type { get; set; }
        public string Menuname { get; set; }
        public string Imgurl { get; set; }
        public int? Sort { get; set; }
        public string Cruid { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
