using System;
using System.Collections.Generic;
using System.Text;
using Serilog.Events;

namespace Shawn.Common.Serilog
{
    public class SerilogOption
    {
        public string pathName { get; set; }
        public string strTempName { get; set; }

        public string logConnectstr{get;set;}
        public string logTableName{get;set;}
        public LogEventLevel logminEvent{get;set;}
    }
}
