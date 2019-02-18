using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrOaNews
    {
        public string FNewsId { get; set; }
        public int? FTypeId { get; set; }
        public string FCategoryId { get; set; }
        public string FCategory { get; set; }
        public string FFullHead { get; set; }
        public string FFullHeadColor { get; set; }
        public string FBriefHead { get; set; }
        public string FAuthorName { get; set; }
        public string FCompileName { get; set; }
        public string FTagWord { get; set; }
        public string FKeyword { get; set; }
        public string FSourceName { get; set; }
        public string FSourceAddress { get; set; }
        public string FNewsContent { get; set; }
        public int? FPv { get; set; }
        public DateTime? FReleaseTime { get; set; }
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
