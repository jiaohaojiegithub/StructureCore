using System;
using System.Collections.Generic;

namespace StudeyPlatFromDB.Models
{
    public partial class SDepot
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string DepotName { get; set; }
        public int? Status { get; set; }
    }
}
