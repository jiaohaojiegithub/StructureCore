using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCTestDB.Models.PublicModel
{
    [Category("用户Toke表")]
    public class UserTokens
    {
        [Description("用户ID")]
        [Key]
        [Column(Order = 0)]
        [StringLength(450)]
        public string UserId { get; set; }

        [Description("授权登录平台")]
        [Key]
        [Column(Order = 1)]
        public string LoginProvider { get; set; }

        [Description("登录属性")]
        [Key]
        [Column(Order = 2)]
        public string Name { get; set; }

        [Description("登录值")]
        public string Value { get; set; }
    }
}
