using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrAppFunction
    {
        public string FId { get; set; }
        public string FType { get; set; }
        public string FFormId { get; set; }
        public string FCodeId { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
        public string FIcon { get; set; }
        public string FName { get; set; }
        public string FSchemeId { get; set; }
        public int? FEnabledMark { get; set; }
        public int? FSortCode { get; set; }
    }
}
