using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SAddress
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Uid { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Areaid { get; set; }
        public string Area { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string Contact { get; set; }
        public string Mobile { get; set; }
        public int? Isdefault { get; set; }
        public DateTime? Crdate { get; set; }
        public DateTime? Update { get; set; }
        public int? Status { get; set; }
    }
}
