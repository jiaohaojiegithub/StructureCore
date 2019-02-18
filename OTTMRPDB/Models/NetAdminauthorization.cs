using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class NetAdminauthorization
    {
        public string Id { get; set; }
        public string Ip { get; set; }
        public string NetId { get; set; }
        public string RoleId { get; set; }
        public string UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? MoidfyDate { get; set; }
        public string ModifyUser { get; set; }
    }
}
