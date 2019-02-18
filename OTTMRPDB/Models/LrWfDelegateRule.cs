using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrWfDelegateRule
    {
        public string FId { get; set; }
        public string FToUserId { get; set; }
        public string FToUserName { get; set; }
        public DateTime? FBeginDate { get; set; }
        public DateTime? FEndDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FCreateDate { get; set; }
        public int? FEnabledMark { get; set; }
        public string FDescription { get; set; }
    }
}
