using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBaseUser
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string UserId { get; set; }
        public string OpenId { get; set; }
        public string UnionId { get; set; }
        public string Mobile { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string UserName { get; set; }
        public string Realname { get; set; }
        public string AvatarUrl { get; set; }
        public int? Gender { get; set; }
        public string SupplierCode { get; set; }
        public string City { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? IsSure { get; set; }
        public int? Status { get; set; }
    }
}
