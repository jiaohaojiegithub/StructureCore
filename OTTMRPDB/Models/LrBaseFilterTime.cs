using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseFilterTime
    {
        public string FFilterTimeId { get; set; }
        public string FObjectType { get; set; }
        public int? FVisitType { get; set; }
        public string FWeekDay1 { get; set; }
        public string FWeekDay2 { get; set; }
        public string FWeekDay3 { get; set; }
        public string FWeekDay4 { get; set; }
        public string FWeekDay5 { get; set; }
        public string FWeekDay6 { get; set; }
        public string FWeekDay7 { get; set; }
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
