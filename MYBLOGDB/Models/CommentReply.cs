using System;
using System.Collections.Generic;

namespace MYBLOGDB.Models
{
    public partial class CommentReply
    {
        public int CommentReplyId { get; set; }
        public int CommentId { get; set; }
        public string CommentReplyContene { get; set; }
        public DateTime CommentReplyCreatDt { get; set; }
        public int UserCardId { get; set; }
    }
}
