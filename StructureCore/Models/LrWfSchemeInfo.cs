using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrWfSchemeInfo
    {
        public string FId { get; set; }
        public string FCode { get; set; }
        public string FName { get; set; }
        public string FCategory { get; set; }
        public int? FKind { get; set; }
        public string FSchemeId { get; set; }
        public int FDeleteMark { get; set; }
        public int FEnabledMark { get; set; }
        public string FDescription { get; set; }
        public int? FIsApp { get; set; }
    }
}
