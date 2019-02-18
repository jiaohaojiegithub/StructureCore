using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCTestMVC.Areas.Admin.Models
{
    [Category("管理员登录")]
    public class AdminLogin
    {
        [Description("用户名")]
        [Required(ErrorMessage ="请填写用户名")]
        [RegularExpression(@"^[A-Za-z0-9\u4e00-\u9fa5]+$", ErrorMessage = "用户名只能由数字,汉字,字母组成")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "用户名必须为{2}到{1}个字符")]
        public string UserName { get; set; }
        [Display(Name = "密码")]
        [Required(ErrorMessage = "请输入密码")]
        [RegularExpression(@"^[\w]{6,18}$",ErrorMessage ="密码由6至18位的字符，下划线组成")]
        [StringLength(18, MinimumLength = 6, ErrorMessage = "密码必须为{2}到18个字符")]
        [DataType(DataType.Password)]
        public string AdminPassWord { get; set; }
    }
}
