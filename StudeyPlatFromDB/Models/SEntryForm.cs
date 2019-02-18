using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SEntryForm
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public string City { get; set; }
        public string Depotname { get; set; }
        public string Username { get; set; }
        public string Mobile { get; set; }
        public int? Courseid { get; set; }
        public int? Timeid { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
