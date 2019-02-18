using System;
using System.Collections.Generic;

namespace StructureCore.Models
{
    public partial class HmBaseApiLog
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string HttpMethod { get; set; }
        public string Token { get; set; }
        public string HttpRequestHeaders { get; set; }
        public string ActionParams { get; set; }
        public DateTime? ExecuteStartTime { get; set; }
        public DateTime? ExecuteEndTime { get; set; }
        public int? IsException { get; set; }
        public string Exception { get; set; }
        public string Response { get; set; }
    }
}
