using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrImContent
    {
        public string FContentId { get; set; }
        public int? FIsGroup { get; set; }
        public string FSendId { get; set; }
        public string FToId { get; set; }
        public string FMsgContent { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
    }
}
