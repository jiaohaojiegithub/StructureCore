using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrCrmTrailRecord
    {
        public string FTrailId { get; set; }
        public int? FObjectSort { get; set; }
        public string FObjectId { get; set; }
        public string FTrackContent { get; set; }
        public int? FSortCode { get; set; }
        public int? FDeleteMark { get; set; }
        public int? FEnabledMark { get; set; }
        public string FDescription { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
        public string FTrackTypeId { get; set; }
    }
}
