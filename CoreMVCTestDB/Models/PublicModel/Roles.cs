using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCTestDB.Models.PublicModel
{
    [Category("权限表")]
    public class Roles
    {
        [Description("权限ID")]
        [StringLength(450)]
        public string Id { get; set; }

        [Description("权限名")]
        [StringLength(256)]
        public string Name { get; set; }

        [Description("统一格式的权限名")]
        [StringLength(256)]
        public string NormalizedName { get; set; }

        [Description("暂时作为标识")]
        public string ConcurrencyStamp { get; set; }

        [Description("鉴别器")]
        [Required]
        public string Discriminator { get; set; }
    }
}
