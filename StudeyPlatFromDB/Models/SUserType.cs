using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SUserType
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Typename { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
