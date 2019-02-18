using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrCrmCustomerContact
    {
        public string FCustomerContactId { get; set; }
        public string FCustomerId { get; set; }
        public string FContact { get; set; }
        public int? FGender { get; set; }
        public string FMobile { get; set; }
        public string FTel { get; set; }
        public string FFax { get; set; }
        public string FQq { get; set; }
        public string FEmail { get; set; }
        public string FWechat { get; set; }
        public string FPostId { get; set; }
        public string FHobby { get; set; }
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
