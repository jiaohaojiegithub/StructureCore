using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SCommentReply
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int? Courseid { get; set; }
        public int? Commentid { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public int? Integral { get; set; }
        public string Uid { get; set; }
        public int? Type { get; set; }
        public DateTime? Crdate { get; set; }
        public int? Status { get; set; }
    }
}
