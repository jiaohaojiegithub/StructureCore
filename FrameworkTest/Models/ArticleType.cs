namespace FrameworkTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArticleType")]
    public partial class ArticleType
    {
        [Key]
        public int ArticleType_ID { get; set; }

        [Required]
        public string ArticleType_Name { get; set; }

        public int Forum_ID { get; set; }
    }
}
