using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrWeChatDeptRelation
    {
        public string FDeptRelationId { get; set; }
        public string FDeptId { get; set; }
        public string FDeptName { get; set; }
        public int? FWeChatDeptId { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
    }
}
