using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrOaEmailAddressee
    {
        public string FAddresseeId { get; set; }
        public string FContentId { get; set; }
        public string FCategoryId { get; set; }
        public string FRecipientId { get; set; }
        public string FRecipientName { get; set; }
        public int? FRecipientState { get; set; }
        public int? FIsRead { get; set; }
        public int? FReadCount { get; set; }
        public DateTime? FReadDate { get; set; }
        public int? FIsHighlight { get; set; }
        public int? FBacklog { get; set; }
        public int? FDeleteMark { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
