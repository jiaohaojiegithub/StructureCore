using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrCrmExpenses
    {
        public string FExpensesId { get; set; }
        public DateTime? FExpensesDate { get; set; }
        public decimal? FExpensesPrice { get; set; }
        public string FExpensesAccount { get; set; }
        public string FExpensesType { get; set; }
        public string FExpensesAbstract { get; set; }
        public int? FSortCode { get; set; }
        public int? FDeleteMark { get; set; }
        public int? FEnabledMark { get; set; }
        public string FDescription { get; set; }
        public DateTime? FCreateDate { get; set; }
        public string FCreateUserId { get; set; }
        public string FCreateUserName { get; set; }
        public DateTime? FModifyDate { get; set; }
        public string FModifyUserId { get; set; }
        public string FModifyUserName { get; set; }
        public int? FExpensesObject { get; set; }
        public string FManagers { get; set; }
    }
}
