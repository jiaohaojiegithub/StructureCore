using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseModuleColumn
    {
        public string FModuleColumnId { get; set; }
        public string FModuleId { get; set; }
        public string FParentId { get; set; }
        public string FEnCode { get; set; }
        public string FFullName { get; set; }
        public int? FSortCode { get; set; }
        public string FDescription { get; set; }
    }
}
