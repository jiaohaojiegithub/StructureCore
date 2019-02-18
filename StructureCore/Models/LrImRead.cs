using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrImRead
    {
        public string FReadId { get; set; }
        public string FContentId { get; set; }
        public string FUserId { get; set; }
        public string FSendId { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public int? FReadStatus { get; set; }
    }
}
