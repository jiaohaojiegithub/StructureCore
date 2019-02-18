using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrOaSchedule
    {
        public string FScheduleId { get; set; }
        public string FScheduleName { get; set; }
        public string FScheduleContent { get; set; }
        public string FCategory { get; set; }
        public DateTime? FStartDate { get; set; }
        public string FStartTime { get; set; }
        public DateTime? FEndDate { get; set; }
        public string FEndTime { get; set; }
        public int? FEarly { get; set; }
        public int? FIsMailAlert { get; set; }
        public int? FIsMobileAlert { get; set; }
        public int? FIsWeChatAlert { get; set; }
        public int? FScheduleState { get; set; }
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
