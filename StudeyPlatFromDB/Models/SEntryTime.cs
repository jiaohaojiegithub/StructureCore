using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SEntryTime
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Courseid { get; set; }
        public string Time { get; set; }
        public int Status { get; set; }
    }
}
