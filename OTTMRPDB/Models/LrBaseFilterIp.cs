using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseFilterIp
    {
        public string FFilterIpid { get; set; }
        public string FObjectType { get; set; }
        public string FObjectId { get; set; }
        public int? FVisitType { get; set; }
        public int? FType { get; set; }
        public string FIplimit { get; set; }
        public int? FSortCode { get; set; }
        public int? FDeleteMark { get; set; }
        public int? FEnabledMark { get; set; }
        public string FDescription { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
