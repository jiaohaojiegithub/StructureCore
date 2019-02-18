using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrCrmReceivable
    {
        public string FReceivableId { get; set; }
        public string FOrderId { get; set; }
        public DateTime? FPaymentTime { get; set; }
        public decimal? FPaymentPrice { get; set; }
        public string FPaymentMode { get; set; }
        public string FPaymentAccount { get; set; }
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
