using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrImGroup
    {
        public string FGroupId { get; set; }
        public string FFullName { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
    }
}
