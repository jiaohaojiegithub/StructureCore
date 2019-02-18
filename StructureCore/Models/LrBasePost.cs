using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrBasePost
    {
        public string FPostId { get; set; }
        public string FParentId { get; set; }
        public string FName { get; set; }
        public string FEnCode { get; set; }
        public string FCompanyId { get; set; }
        public string FDepartmentId { get; set; }
        public int? FDeleteMark { get; set; }
        public string FDescription { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
