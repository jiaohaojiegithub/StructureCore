using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseModuleButton
    {
        public string FModuleButtonId { get; set; }
        public string FModuleId { get; set; }
        public string FParentId { get; set; }
        public string FIcon { get; set; }
        public string FEnCode { get; set; }
        public string FFullName { get; set; }
        public string FActionAddress { get; set; }
        public int? FSortCode { get; set; }
    }
}
