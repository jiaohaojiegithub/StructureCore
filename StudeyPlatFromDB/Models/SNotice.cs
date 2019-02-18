using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SNotice
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public int? Type { get; set; }
        public int? Courseid { get; set; }
        public int? Relateid { get; set; }
        public string Action { get; set; }
        public string Content { get; set; }
        public int? Unread { get; set; }
        public string Replyuid { get; set; }
        public DateTime? Readdate { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
