using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class LrBaseDataCondition
    {
        public string FId { get; set; }
        public string FDataAuthorizeRelationId { get; set; }
        public string FFieldId { get; set; }
        public string FFieldName { get; set; }
        public int? FFieldType { get; set; }
        public int? FSymbol { get; set; }
        public string FSymbolName { get; set; }
        public int? FFiledValueType { get; set; }
        public string FFiledValue { get; set; }
        public int? FSort { get; set; }
    }
}
