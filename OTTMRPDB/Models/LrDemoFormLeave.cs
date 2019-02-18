using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrDemoFormLeave
    {
        public string FId { get; set; }
        public int? FType { get; set; }
        public int? FNum { get; set; }
        public string FReason { get; set; }
        public DateTime? FBegin { get; set; }
        public DateTime? FEnd { get; set; }
        public string FFileId { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FdataItem { get; set; }
    }
}
