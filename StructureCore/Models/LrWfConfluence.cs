using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrWfConfluence
    {
        public string FId { get; set; }
        public string FProcessId { get; set; }
        public string FNodeId { get; set; }
        public string FFormNodeId { get; set; }
        public int? FIsOk { get; set; }
    }
}
