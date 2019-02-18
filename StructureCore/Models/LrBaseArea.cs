using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrBaseArea
    {
        public string FAreaId { get; set; }
        public string FParentId { get; set; }
        public string FAreaCode { get; set; }
        public string FAreaName { get; set; }
        public string FQuickQuery { get; set; }
        public string FSimpleSpelling { get; set; }
        public int? FLayer { get; set; }
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
