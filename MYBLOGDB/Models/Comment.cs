using System;
using System.Collections.Generic;

namespace MYBLOGDB.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int ArticleId { get; set; }
        public string CommentContene { get; set; }
        public DateTime CommentCreatDt { get; set; }
        public int UserCardId { get; set; }
    }
}
