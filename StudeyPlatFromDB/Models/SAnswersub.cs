using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SAnswersub
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public int? Answerid { get; set; }
        public int? Subjectid { get; set; }
        public string Answer { get; set; }
        public int? Isright { get; set; }
        public int Score { get; set; }
        public int Ischeck { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
