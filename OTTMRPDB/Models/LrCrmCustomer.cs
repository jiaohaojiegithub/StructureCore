using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrCrmCustomer
    {
        public string FCustomerId { get; set; }
        public string FEnCode { get; set; }
        public string FFullName { get; set; }
        public string FShortName { get; set; }
        public string FCustIndustryId { get; set; }
        public string FCustTypeId { get; set; }
        public string FCustLevelId { get; set; }
        public string FCustDegreeId { get; set; }
        public string FProvince { get; set; }
        public string FCity { get; set; }
        public string FContact { get; set; }
        public string FMobile { get; set; }
        public string FTel { get; set; }
        public string FFax { get; set; }
        public string FQq { get; set; }
        public string FEmail { get; set; }
        public string FWechat { get; set; }
        public string FHobby { get; set; }
        public string FLegalPerson { get; set; }
        public string FCompanyAddress { get; set; }
        public string FCompanySite { get; set; }
        public string FCompanyDesc { get; set; }
        public string FTraceUserId { get; set; }
        public string FTraceUserName { get; set; }
        public DateTime? FAlertDateTime { get; set; }
        public int? FAlertState { get; set; }
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
