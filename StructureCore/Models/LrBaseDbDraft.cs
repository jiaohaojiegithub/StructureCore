using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrBaseDbDraft
    {
        public string FId { get; set; }
        public string FName { get; set; }
        public string FContent { get; set; }
        public string FRemark { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
    }
}
