using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseLog
    {
        public string FLogId { get; set; }
        public int? FCategoryId { get; set; }
        public string FSourceObjectId { get; set; }
        public string FSourceContentJson { get; set; }
        public DateTime? FOperateTime { get; set; }
        public string FOperateUserId { get; set; }
        public string FOperateAccount { get; set; }
        public string FOperateTypeId { get; set; }
        public string FOperateType { get; set; }
        public string FModule { get; set; }
        public string FIpaddress { get; set; }
        public string FIpaddressName { get; set; }
        public string FHost { get; set; }
        public string FBrowser { get; set; }
        public int? FExecuteResult { get; set; }
        public string FExecuteResultJson { get; set; }
        public string FDescription { get; set; }
        public int? FDeleteMark { get; set; }
        public int? FEnabledMark { get; set; }
    }
}
