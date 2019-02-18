using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrWfSchemeAuthorize
    {
        public string FId { get; set; }
        public string FSchemeInfoId { get; set; }
        public string FObjectName { get; set; }
        public string FObjectId { get; set; }
        public int? FObjectType { get; set; }
    }
}
