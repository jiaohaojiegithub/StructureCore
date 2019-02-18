using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrWfTaskHistory
    {
        public string FId { get; set; }
        public string FProcessId { get; set; }
        public string FNodeId { get; set; }
        public string FNodeName { get; set; }
        public int? FTaskType { get; set; }
        public int? FResult { get; set; }
        public string FPreviousId { get; set; }
        public string FPreviousName { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public string FDescription { get; set; }
    }
}
