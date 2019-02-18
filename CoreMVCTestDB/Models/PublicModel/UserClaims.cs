using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCTestDB.Models.PublicModel
{
    [Category("用户声明表")]
    public class UserClaims
    {
        [Description("用户声明ID")]
        public int Id { get; set; }

        [Description("用户ID")]
        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        [Description("声明类型")]
        public string ClaimType { get; set; }

        [Description("声明")]
        public string ClaimValue { get; set; }

    }
}
