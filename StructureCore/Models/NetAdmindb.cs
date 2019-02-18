using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class NetAdmindb
    {
        public string Id { get; set; }
        public string Pid { get; set; }
        public string DbIpaddress { get; set; }
        public string DbPort { get; set; }
        public string DbUserName { get; set; }
        public string DbUserPassword { get; set; }
        public string DbRemark { get; set; }
    }
}
