using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrCrmInvoice
    {
        public string FInvoiceId { get; set; }
        public string FCustomerId { get; set; }
        public string FCustomerCode { get; set; }
        public string FCustomerName { get; set; }
        public string FInvoiceContent { get; set; }
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
