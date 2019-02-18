using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseUserRelation
    {
        public string FUserRelationId { get; set; }
        public string FUserId { get; set; }
        public int? FCategory { get; set; }
        public string FObjectId { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
    }
}
