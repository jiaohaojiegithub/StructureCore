using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrCrmOrder
    {
        public string FOrderId { get; set; }
        public string FCustomerId { get; set; }
        public string FSellerId { get; set; }
        public DateTime? FOrderDate { get; set; }
        public string FOrderCode { get; set; }
        public decimal? FDiscountSum { get; set; }
        public decimal? FAccounts { get; set; }
        public decimal? FReceivedAmount { get; set; }
        public DateTime? FPaymentDate { get; set; }
        public string FPaymentMode { get; set; }
        public int? FPaymentState { get; set; }
        public decimal? FSaleCost { get; set; }
        public string FAbstractInfo { get; set; }
        public string FContractCode { get; set; }
        public string FContractFile { get; set; }
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
