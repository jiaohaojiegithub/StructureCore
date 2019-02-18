using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SComment
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int? Courseid { get; set; }
        public string Uid { get; set; }
        public string Content { get; set; }
        public int? Integral { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
