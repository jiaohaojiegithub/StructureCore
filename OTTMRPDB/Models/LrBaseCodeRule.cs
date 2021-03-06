﻿using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseCodeRule
    {
        public string FRuleId { get; set; }
        public string FEnCode { get; set; }
        public string FFullName { get; set; }
        public string FCurrentNumber { get; set; }
        public string FRuleFormatJson { get; set; }
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
