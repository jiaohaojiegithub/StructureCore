using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SGrade
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public int? Reg { get; set; }
        public int? Greenhand { get; set; }
        public int? Salesskill { get; set; }
        public int? Professionalknowledge { get; set; }
        public int? Allcourse { get; set; }
        public int? Comment { get; set; }
        public int? Reply { get; set; }
        public int? Feedback { get; set; }
        public int? Grade { get; set; }
        public string Gradename { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
