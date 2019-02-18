namespace FrameworkTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Login()
        {
            User_Card = new HashSet<User_Card>();
        }

        [Key]
        public int UserLogin_ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UserLogin_CreatDT { get; set; }

        public Guid UserLogin_Guid { get; set; }

        [Required]
        [StringLength(20)]
        public string UserLogin_Name { get; set; }

        [Required]
        [StringLength(18)]
        public string UserLogin_PassWord { get; set; }

        public bool UserLogin_State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Card> User_Card { get; set; }
    }
}
