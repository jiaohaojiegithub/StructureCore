using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrCrmCashBalance
    {
        public string FCashBalanceId { get; set; }
        public string FObjectId { get; set; }
        public DateTime? FExecutionDate { get; set; }
        public string FCashAccount { get; set; }
        public decimal? FReceivable { get; set; }
        public decimal? FExpenses { get; set; }
        public decimal? FBalance { get; set; }
        public string FAbstract { get; set; }
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
