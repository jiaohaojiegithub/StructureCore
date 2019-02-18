using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrWfDelegateRecord
    {
        public string FId { get; set; }
        public string FWfdelegateRuleId { get; set; }
        public string FFromUserId { get; set; }
        public string FFromUserName { get; set; }
        public string FToUserId { get; set; }
        public string FToUserName { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FProcessId { get; set; }
        public string FProcessCode { get; set; }
        public string FProcessName { get; set; }
    }
}
