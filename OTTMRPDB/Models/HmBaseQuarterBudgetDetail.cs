using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseQuarterBudgetDetail
    {
        public int Id { get; set; }
        public string QuarterCode { get; set; }
        public string QuarterName { get; set; }
        public int? RelateId { get; set; }
        public decimal? Sum { get; set; }
        public int? Status { get; set; }
    }
}
