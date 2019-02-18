using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SSubject
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int? Testpaperid { get; set; }
        public string Title { get; set; }
        public string Option { get; set; }
        public string Right { get; set; }
        public string Category { get; set; }
        public int? Sort { get; set; }
        public int? Score { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
