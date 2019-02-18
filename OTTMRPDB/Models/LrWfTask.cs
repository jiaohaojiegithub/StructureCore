using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrWfTask
    {
        public string FId { get; set; }
        public string FProcessId { get; set; }
        public string FNodeId { get; set; }
        public string FNodeName { get; set; }
        public int? FTaskType { get; set; }
        public int? FIsFinished { get; set; }
        public string FAuditorId { get; set; }
        public string FAuditorName { get; set; }
        public string FCompanyId { get; set; }
        public string FDepartmentId { get; set; }
        public int? FTimeoutAction { get; set; }
        public int? FTimeoutNotice { get; set; }
        public string FPreviousId { get; set; }
        public string FPreviousName { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
