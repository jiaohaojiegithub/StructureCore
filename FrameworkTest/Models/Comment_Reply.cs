namespace FrameworkTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment_Reply
    {
        [Key]
        public int Comment_Reply_ID { get; set; }

        public int Comment_ID { get; set; }

        [StringLength(500)]
        public string Comment_Reply_Contene { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Comment_Reply_CreatDT { get; set; }

        public int UserCard_ID { get; set; }
    }
}
