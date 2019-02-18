using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrWeChatUserRelation
    {
        public string FUserRelationId { get; set; }
        public string FDeptId { get; set; }
        public string FDeptName { get; set; }
        public int? FWeChatDeptId { get; set; }
        public string FUserId { get; set; }
        public string FSyncState { get; set; }
        public string FSyncLog { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
    }
}
