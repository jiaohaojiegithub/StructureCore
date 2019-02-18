using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBasePurchaseOrder
    {
        public int Id { get; set; }
        public string PurchaseOrderId { get; set; }
        public string SumRequestId { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string FabricCode { get; set; }
        public string StyleId { get; set; }
        public decimal? Num { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? Sum { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string SupplierCode { get; set; }
        public double? SureDays { get; set; }
        public double? ColoringDays { get; set; }
        public double? AfterfinishDays { get; set; }
        public double? GoodsDays { get; set; }
        public double? PrintingDays { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public int? Step { get; set; }
        public string SubmitUser { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string ExpectDate { get; set; }
        public string Comment { get; set; }
        public string CheckUser { get; set; }
        public DateTime? CheckDate { get; set; }
        public string ReComment { get; set; }
        public int? Status { get; set; }
        public int? Type { get; set; }
        public int? BudgetDetailId { get; set; }
    }
}
