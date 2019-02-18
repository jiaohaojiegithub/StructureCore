using System;
using System.Collections.Generic;

namespace OTTMRPDB.Models
{
    public partial class HmBaseInStore
    {
        public int Id { get; set; }
        public string InStoreId { get; set; }
        public string ReceiveId { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string FabricCode { get; set; }
        public string StyleId { get; set; }
        public int? Shnum { get; set; }
        public decimal? Num { get; set; }
        public decimal? SamplePrice { get; set; }
        public decimal? Sum { get; set; }
        public string SupplierCode { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string InStoreUser { get; set; }
        public DateTime? InStoreDate { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string Comment { get; set; }
        public int? Step { get; set; }
        public int? Status { get; set; }
        public int? BudgetDetailId { get; set; }
    }
}
