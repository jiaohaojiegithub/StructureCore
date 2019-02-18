using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMVC.Models
{
    public class Users
    {
        [Description("用户ID")]
        [StringLength(450),Display(Name = "用户ID")]
        public string Id { get; set; }

        [Description("用户名")]
        [StringLength(256),Display(Name = "用户名")]
        public string UserName { get; set; }

        [Description("统一用户名")]
        [StringLength(256),Display(Name = "统一用户名")]
        public string NormalizedUserName { get; set; }

        [Description("用户邮箱")]
        [StringLength(256),Display(Name = "用户邮箱")]
        public string Email { get; set; }

        [Description("统一邮箱格式")]
        [StringLength(256)]
        public string NormalizedEmail { get; set; }

        [Description("是否添加邮箱")]
        public bool EmailConfirmed { get; set; }

        [Description("密码")]
        public string PasswordHash { get; set; }

        [Description("安全标识")]
        public string SecurityStamp { get; set; }

        [Description("并发标识")]
        public string ConcurrencyStamp { get; set; }

        [Description("电话号码")]
        public string PhoneNumber { get; set; }

        [Description("是否添加电话号码")]
        public bool PhoneNumberConfirmed { get; set; }

        [Description("两个因素使")]
        public bool TwoFactorEnabled { get; set; }

        [Description("")]
        public DateTimeOffset? LockoutEnd { get; set; }

        public bool LockoutEnabled { get; set; }

        [Description("登录失败次数")]
        public int AccessFailedCount { get; set; }

        [Required,DataType(DataType.DateTime),Display(Name ="创建时间")]
        public DateTime CreateTime { get; set; }
    }
}
