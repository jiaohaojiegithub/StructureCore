using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseFabric
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string FabricCode { get; set; }
        public string FabricName { get; set; }
        public string SupplierCode { get; set; }
        public string Mobile { get; set; }
        public string ValidWidth { get; set; }
        public string ValidWidthUnit { get; set; }
        public double? UseWidth { get; set; }
        public string UseWidthUnit { get; set; }
        public string Component { get; set; }
        public string GramWeight { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? GoodsPrice { get; set; }
        public string StartQuantity { get; set; }
        public double? ArrivalDays { get; set; }
        public string Shrinkage { get; set; }
        public string Pnremark { get; set; }
        public string Picture { get; set; }
        public string Remark { get; set; }
        public double? SureDays { get; set; }
        public double? ColoringDays { get; set; }
        public double? AfterfinishDays { get; set; }
        public double? GoodsDays { get; set; }
        public double? PrintingDays { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public int? Status { get; set; }
        public string FabricClass { get; set; }
    }
}
