using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SMobileCode
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Mobile { get; set; }
        public string Code { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
