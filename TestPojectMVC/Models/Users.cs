using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPojectMVC.Models
{
    public class Users:IdentityUser
    {
        [Required]
        public string MD5PassWord { get; set; }
        [DataType(DataType.DateTime),Display(Name = "创建时间")]
        public DateTime CreateDT { get; set; }
    }
}
