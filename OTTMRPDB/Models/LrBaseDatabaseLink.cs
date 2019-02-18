using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class LrBaseDatabaseLink
    {
        public string FDatabaseLinkId { get; set; }
        public string FServerAddress { get; set; }
        public string FDbname { get; set; }
        public string FDbalias { get; set; }
        public string FDbType { get; set; }
        public string FVersion { get; set; }
        public string FDbConnection { get; set; }
        public int? FDesencrypt { get; set; }
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
