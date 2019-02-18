using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseDepotid
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string DepotId { get; set; }
        public string DepotName { get; set; }
        public string Address { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public int? Status { get; set; }
    }
}
