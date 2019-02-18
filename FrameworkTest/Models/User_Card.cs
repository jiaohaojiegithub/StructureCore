namespace FrameworkTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Card
    {
        [Key]
        public int UserCard_ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UserCard_Birthday { get; set; }

        public string UserCard_ChatHeadImg { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UserCard_CreatDt { get; set; }

        public int UserCard_GmLevel { get; set; }

        public string UserCard_MobilPhone { get; set; }

        [Required]
        [StringLength(20)]
        public string UserCard_Nickname { get; set; }

        [StringLength(80)]
        public string UserCard_Remark { get; set; }

        [Required]
        public string UserCard_Sex { get; set; }

        public int UserLogin_ID { get; set; }

        public virtual User_Login User_Login { get; set; }
    }
}
