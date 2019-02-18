using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrWfProcessInstance
    {
        public string FId { get; set; }
        public string FSchemeId { get; set; }
        public string FSchemeCode { get; set; }
        public string FSchemeName { get; set; }
        public string FProcessName { get; set; }
        public int? FProcessLevel { get; set; }
        public int FEnabledMark { get; set; }
        public int? FIsFinished { get; set; }
        public int? FIsAgain { get; set; }
        public string FDescription { get; set; }
        public DateTime FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public string FCompanyId { get; set; }
        public string FDepartmentId { get; set; }
        public int? FIsChildFlow { get; set; }
        public string FProcessParentId { get; set; }
    }
}
