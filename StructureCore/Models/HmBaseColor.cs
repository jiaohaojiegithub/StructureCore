using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBaseColor
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string ColorId { get; set; }
        public string ColorName { get; set; }
        public string Picture { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public int? Status { get; set; }
    }
}
