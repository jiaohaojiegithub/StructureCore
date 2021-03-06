﻿using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseDepartment
    {
        public string FDepartmentId { get; set; }
        public string FCompanyId { get; set; }
        public string FParentId { get; set; }
        public string FEnCode { get; set; }
        public string FFullName { get; set; }
        public string FShortName { get; set; }
        public string FNature { get; set; }
        public string FManager { get; set; }
        public string FOuterPhone { get; set; }
        public string FInnerPhone { get; set; }
        public string FEmail { get; set; }
        public string FFax { get; set; }
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
