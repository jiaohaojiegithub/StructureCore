using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrCrmChance
    {
        public string FChanceId { get; set; }
        public string FEnCode { get; set; }
        public string FFullName { get; set; }
        public string FSourceId { get; set; }
        public string FStageId { get; set; }
        public decimal? FSuccessRate { get; set; }
        public decimal? FAmount { get; set; }
        public decimal? FProfit { get; set; }
        public string FChanceTypeId { get; set; }
        public decimal? FSaleCost { get; set; }
        public DateTime? FDealDate { get; set; }
        public int? FIsToCustom { get; set; }
        public string FCompanyName { get; set; }
        public string FCompanyNatureId { get; set; }
        public string FCompanyAddress { get; set; }
        public string FCompanySite { get; set; }
        public string FCompanyDesc { get; set; }
        public string FProvince { get; set; }
        public string FCity { get; set; }
        public string FContacts { get; set; }
        public string FMobile { get; set; }
        public string FTel { get; set; }
        public string FFax { get; set; }
        public string FQq { get; set; }
        public string FEmail { get; set; }
        public string FWechat { get; set; }
        public string FHobby { get; set; }
        public string FTraceUserId { get; set; }
        public string FTraceUserName { get; set; }
        public int? FChanceState { get; set; }
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
