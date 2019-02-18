using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseStyle
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string StyleId { get; set; }
        public string StyleName { get; set; }
        public string Year { get; set; }
        public string Season { get; set; }
        public string Band { get; set; }
        public string ImgUrl { get; set; }
        public string Designer { get; set; }
        public string Master { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? Status { get; set; }
    }
}
