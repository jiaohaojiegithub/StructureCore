using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrDemoSingle
    {
        public string FId { get; set; }
        public string FName { get; set; }
        public string FType { get; set; }
        public string FDes { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
