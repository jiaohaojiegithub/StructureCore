namespace FrameworkTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lable")]
    public partial class Lable
    {
        [Key]
        public int Lable_ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Lable_CreatDT { get; set; }

        [Required]
        [StringLength(150)]
        public string Lable_Remark { get; set; }

        [Required]
        public string Lable_Text { get; set; }
    }
}
