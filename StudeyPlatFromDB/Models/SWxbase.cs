using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SWxbase
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Appid { get; set; }
        public string Appsecret { get; set; }
        public string Token { get; set; }
        public DateTime? Update { get; set; }
        public int? Tab { get; set; }
    }
}
