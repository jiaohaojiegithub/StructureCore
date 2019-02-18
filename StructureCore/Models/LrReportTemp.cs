using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrReportTemp
    {
        public string FTempId { get; set; }
        public string FFullName { get; set; }
        public string FEnCode { get; set; }
        public string FTempCategory { get; set; }
        public string FTempStyle { get; set; }
        public string FTempType { get; set; }
        public string FDescription { get; set; }
        public string FParamJson { get; set; }
        public int? FSortCode { get; set; }
        public int? FDeleteMark { get; set; }
        public int? FEnabledMark { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
