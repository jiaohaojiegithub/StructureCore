using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCTestMVC.Models
{
    public class WebSetting
    {
        public class ConnectionStrings
        {
            public string DefaultConnection { get; set; }
            public string CoreMVCConnection { get; set; }
        }
        public class Logging
        {
            public class LogLevel
            {
                public string Default { get; set; }
            }
        }
        public string AllowedHosts { get; set; }
    }
}
