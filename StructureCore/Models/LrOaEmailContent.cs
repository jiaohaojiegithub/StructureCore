using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrOaEmailContent
    {
        public string FContentId { get; set; }
        public string FCategoryId { get; set; }
        public string FParentId { get; set; }
        public string FTheme { get; set; }
        public string FThemeColor { get; set; }
        public string FEmailContent { get; set; }
        public string FFiles { get; set; }
        public int? FEmailType { get; set; }
        public string FSenderId { get; set; }
        public string FSenderName { get; set; }
        public DateTime? FSenderTime { get; set; }
        public int? FIsHighlight { get; set; }
        public string FSendPriority { get; set; }
        public int? FIsSmsReminder { get; set; }
        public int? FIsReceipt { get; set; }
        public string FAddresssHtml { get; set; }
        public string FCopysendHtml { get; set; }
        public string FBccsendHtml { get; set; }
        public int? FSendState { get; set; }
        public int? FDeleteMark { get; set; }
        public int? FEnabledMark { get; set; }
        public string FDescription { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
    }
}
