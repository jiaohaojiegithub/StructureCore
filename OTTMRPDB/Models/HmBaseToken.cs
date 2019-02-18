using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseToken
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public string Token { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
