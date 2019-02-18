namespace FrameworkTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        public int Comment_ID { get; set; }

        public int Article_ID { get; set; }

        [StringLength(500)]
        public string Comment_Contene { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Comment_CreatDT { get; set; }

        public int UserCard_ID { get; set; }
    }
}
