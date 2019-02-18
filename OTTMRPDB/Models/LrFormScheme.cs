using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrFormScheme
    {
        public string FId { get; set; }
        public string FSchemeInfoId { get; set; }
        public int? FType { get; set; }
        public string FScheme { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
    }
}
