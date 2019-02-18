using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrExcelImportFileds
    {
        public string FId { get; set; }
        public string FImportId { get; set; }
        public string FName { get; set; }
        public string FColName { get; set; }
        public int? FOnlyOne { get; set; }
        public int? FRelationType { get; set; }
        public string FDataItemCode { get; set; }
        public string FValue { get; set; }
        public string FDataSourceId { get; set; }
        public int? FSortCode { get; set; }
    }
}
