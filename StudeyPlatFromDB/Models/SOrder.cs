using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SOrder
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public string Contact { get; set; }
        public string Mobile { get; set; }
        public int? Goodsid { get; set; }
        public string Goodsname { get; set; }
        public int? Integral { get; set; }
        public int? Addressid { get; set; }
        public string Address { get; set; }
        public int? Step { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
