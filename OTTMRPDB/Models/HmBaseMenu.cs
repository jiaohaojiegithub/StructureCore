using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseMenu
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public int? Type { get; set; }
        public string MenuName { get; set; }
        public string ImgUrl { get; set; }
        public int? ParentId { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Sort { get; set; }
        public int? Status { get; set; }
    }
}
