using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseAuthorize
    {
        public string FAuthorizeId { get; set; }
        public int? FObjectType { get; set; }
        public string FObjectId { get; set; }
        public int? FItemType { get; set; }
        public string FItemId { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
    }
}
