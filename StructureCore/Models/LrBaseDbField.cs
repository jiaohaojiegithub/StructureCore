using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrBaseDbField
    {
        public string FId { get; set; }
        public string FName { get; set; }
        public string FDataType { get; set; }
        public string FRemark { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public int? FLength { get; set; }
    }
}
