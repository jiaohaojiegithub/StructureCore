namespace FrameworkTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        [Key]
        public int Article_ID { get; set; }

        public int ArticleType_ID { get; set; }

        public string Article_Abstract { get; set; }

        public string Article_Content { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Article_CreateDT { get; set; }

        public string Article_Img { get; set; }

        public string Article_Title { get; set; }

        [Required]
        public string Lable_ID { get; set; }

        public int UserCard_ID { get; set; }
    }
}
