using System;
using System.Collections.Generic;

namespace MYBLOGDB.Models
{
    public partial class Article
    {
        public int ArticleId { get; set; }
        public int ArticleTypeId { get; set; }
        public string ArticleAbstract { get; set; }
        public string ArticleContent { get; set; }
        public DateTime ArticleCreateDt { get; set; }
        public string ArticleImg { get; set; }
        public string ArticleTitle { get; set; }
        public string LableId { get; set; }
        public int UserCardId { get; set; }
    }
}
