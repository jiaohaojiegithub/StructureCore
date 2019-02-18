using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBaseSupplierSure
    {
        public int Id { get; set; }
        public string SupplierSureId { get; set; }
        public string PurchaseOrderId { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string FabricCode { get; set; }
        public string StyleId { get; set; }
        public decimal? Num { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? Sum { get; set; }
        public string SupplierCode { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ExpressName { get; set; }
        public string ExpressNum { get; set; }
        public string Comment { get; set; }
        public string SendUser { get; set; }
        public DateTime? SendDate { get; set; }
        public string CheckUser { get; set; }
        public string CheckDate { get; set; }
        public string ReComment { get; set; }
        public int? Step { get; set; }
        public int? Status { get; set; }
        public int? BudgetDetailId { get; set; }
        public string ExpectDate { get; set; }
        public string RealSendDate { get; set; }
    }
}
