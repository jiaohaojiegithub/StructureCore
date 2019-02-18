using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCTestDB.Models.PublicModel
{
    [Category("用户登录表_用于第三方登录")]
    public class UserLogins
    {
        [Description("授权登录平台")]
        [Key]
        [Column(Order = 0)]
        public string LoginProvider { get; set; }

        [Description("授权Key")]
        [Key]
        [Column(Order = 1)]
        public string ProviderKey { get; set; }

        [Description("供应商显示名称")]
        public string ProviderDisplayName { get; set; }

        [Description("用户ID")]
        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

    }
}
