using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SGoods
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Goodsimg { get; set; }
        public string Goodsname { get; set; }
        public int? Integral { get; set; }
        public int? Stock { get; set; }
        public int? Online { get; set; }
        public int ExchangeTime { get; set; }
        public string Remark { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
