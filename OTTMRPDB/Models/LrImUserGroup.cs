using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrImUserGroup
    {
        public string FUserGroupId { get; set; }
        public string FGroupId { get; set; }
        public string FUserId { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
    }
}
