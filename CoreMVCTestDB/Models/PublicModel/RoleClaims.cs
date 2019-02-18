using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreMVCTestDB.Models.PublicModel
{
    [Category("权限声明表")]
    public class RoleClaims
    {
        [Description("权限声明ID")]
        public int Id { get; set; }

        [Description("权限ID")]
        [Required]
        [StringLength(450)]
        public string RoleId { get; set; }

        [Description("声明类型")]
        public string ClaimType { get; set; }

        [Description("声明")]
        public string ClaimValue { get; set; }
    }
}
