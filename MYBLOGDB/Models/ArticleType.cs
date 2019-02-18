using System;
using System.Collections.Generic;

namespace MYBLOGDB.Models
{
    public partial class ArticleType
    {
        public int ArticleTypeId { get; set; }
        public string ArticleTypeName { get; set; }
        public int ForumId { get; set; }
    }
}
