using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseReceive
    {
        public int Id { get; set; }
        public string ReceiveId { get; set; }
        public string SupplierSureId { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string FabricCode { get; set; }
        public string StyleId { get; set; }
        public int? Fhnum { get; set; }
        public decimal? Num { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? Sum { get; set; }
        public string SupplierCode { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string GetUser { get; set; }
        public DateTime? GetDate { get; set; }
        public DateTime? ArriveDate { get; set; }
        public string RealSendDate { get; set; }
        public string Comment { get; set; }
        public string ReComment { get; set; }
        public int? IsPay { get; set; }
        public int? Step { get; set; }
        public int? Status { get; set; }
        public int? BudgetDetailId { get; set; }
    }
}
