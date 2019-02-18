using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseDataRelation
    {
        public string FId { get; set; }
        public string FName { get; set; }
        public string FInterfaceId { get; set; }
        public string FObjectId { get; set; }
        public int? FObjectType { get; set; }
        public string FFormula { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
