using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrBaseUser
    {
        public string FUserId { get; set; }
        public string FEnCode { get; set; }
        public string FAccount { get; set; }
        public string FPassword { get; set; }
        public string FSecretkey { get; set; }
        public string FRealName { get; set; }
        public string FNickName { get; set; }
        public string FHeadIcon { get; set; }
        public string FQuickQuery { get; set; }
        public string FSimpleSpelling { get; set; }
        public int? FGender { get; set; }
        public DateTime? FBirthday { get; set; }
        public string FMobile { get; set; }
        public string FTelephone { get; set; }
        public string FEmail { get; set; }
        public string FOicq { get; set; }
        public string FWeChat { get; set; }
        public string FMsn { get; set; }
        public string FCompanyId { get; set; }
        public string FDepartmentId { get; set; }
        public int? FSecurityLevel { get; set; }
        public int? FOpenId { get; set; }
        public string FQuestion { get; set; }
        public string FAnswerQuestion { get; set; }
        public int? FCheckOnLine { get; set; }
        public DateTime? FAllowStartTime { get; set; }
        public DateTime? FAllowEndTime { get; set; }
        public DateTime? FLockStartDate { get; set; }
        public DateTime? FLockEndDate { get; set; }
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
