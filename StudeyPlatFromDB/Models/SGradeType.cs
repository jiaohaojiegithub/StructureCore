using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SGradeType
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int? Grade { get; set; }
        public string Gradename { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Staus { get; set; }
    }
}
