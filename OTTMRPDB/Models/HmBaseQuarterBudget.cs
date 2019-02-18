using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseQuarterBudget
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string QuarterCode { get; set; }
        public string QuarterName { get; set; }
        public decimal? QuarterBudget { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public int? Status { get; set; }
    }
}
