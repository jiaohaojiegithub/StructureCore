using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrBaseCodeRuleSeed
    {
        public string FRuleSeedId { get; set; }
        public string FRuleId { get; set; }
        public string FUserId { get; set; }
        public int? FSeedValue { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
