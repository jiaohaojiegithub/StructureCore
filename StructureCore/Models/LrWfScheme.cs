﻿using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrWfScheme
    {
        public string FId { get; set; }
        public string FSchemeInfoId { get; set; }
        public int? FType { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public string FScheme { get; set; }
    }
}
