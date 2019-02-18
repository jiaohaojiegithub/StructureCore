using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrDemoBorrow
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public decimal? Money { get; set; }
        public DateTime? RequestDate { get; set; }
        public string Description { get; set; }
        public string FlowId { get; set; }
        public string FdataItem { get; set; }
    }
}
