using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SManager
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public string Userid { get; set; }
        public string Username { get; set; }
        public string Headimgurl { get; set; }
        public string Password { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
