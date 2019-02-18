using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrOaFileInfo
    {
        public string FFileId { get; set; }
        public string FFolderId { get; set; }
        public string FFileName { get; set; }
        public string FFilePath { get; set; }
        public string FFileSize { get; set; }
        public string FFileExtensions { get; set; }
        public string FFileType { get; set; }
        public int? FIsShare { get; set; }
        public string FShareLink { get; set; }
        public int? FShareCode { get; set; }
        public DateTime? FShareTime { get; set; }
        public int? FDownloadCount { get; set; }
        public int? FIsTop { get; set; }
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
    }
}
