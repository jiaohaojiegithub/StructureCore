using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrFormRelation
    {
        public string FId { get; set; }
        public string FFormId { get; set; }
        public string FModuleId { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
        public string FSettingJson { get; set; }
    }
}
