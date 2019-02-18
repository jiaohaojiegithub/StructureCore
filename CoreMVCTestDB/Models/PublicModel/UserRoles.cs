using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCTestDB.Models.PublicModel
{
    [Category("用户权限表")]
    public class UserRoles
    {
        [Description("权限ID")]
        [StringLength(450)]
        public string RoleId { get; set; }

        [Description("权限ID")]
        [StringLength(450)]
        public string UserId { get; set; }
    }
}
