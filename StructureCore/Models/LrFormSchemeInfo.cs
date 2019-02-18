using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrFormSchemeInfo
    {
        public string FId { get; set; }
        public string FName { get; set; }
        public int? FType { get; set; }
        public string FCategory { get; set; }
        public string FSchemeId { get; set; }
        public int? FDeleteMark { get; set; }
        public int? FEnabledMark { get; set; }
        public string FDescription { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
        public string FUrlAddress { get; set; }
    }
}
