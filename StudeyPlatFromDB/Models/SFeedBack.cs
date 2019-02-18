using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SFeedBack
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public string Content { get; set; }
        public int Isreply { get; set; }
        public string Reply { get; set; }
        public string Replyname { get; set; }
        public DateTime? Replydate { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
