using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrBaseModule
    {
        public string FModuleId { get; set; }
        public string FParentId { get; set; }
        public string FEnCode { get; set; }
        public string FFullName { get; set; }
        public string FIcon { get; set; }
        public string FUrlAddress { get; set; }
        public string FTarget { get; set; }
        public int FIsMenu { get; set; }
        public int? FAllowExpand { get; set; }
        public int? FIsPublic { get; set; }
        public int? FAllowEdit { get; set; }
        public int? FAllowDelete { get; set; }
        public int? FSortCode { get; set; }
        public int FDeleteMark { get; set; }
        public int FEnabledMark { get; set; }
        public string FDescription { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
