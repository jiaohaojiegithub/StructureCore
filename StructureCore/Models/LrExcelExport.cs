using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrExcelExport
    {
        public string FId { get; set; }
        public string FName { get; set; }
        public string FGridId { get; set; }
        public string FModuleId { get; set; }
        public string FModuleBtnId { get; set; }
        public string FBtnName { get; set; }
        public int? FEnabledMark { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
