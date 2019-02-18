using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SToken
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int? Type { get; set; }
        public string Uid { get; set; }
        public string Token { get; set; }
        public DateTime? Update { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
