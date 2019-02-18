using System;
using System.Collections.Generic;

namespace MYBLOGDB.Models
{
    public partial class Lable
    {
        public int LableId { get; set; }
        public DateTime LableCreatDt { get; set; }
        public string LableRemark { get; set; }
        public string LableText { get; set; }
    }
}
