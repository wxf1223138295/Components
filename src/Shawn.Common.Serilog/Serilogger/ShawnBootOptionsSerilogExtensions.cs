using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Shawn.Common.Serilog
{
    public static class ShawnBootOptionsSerilogExtensions
    {
        public static LoggerFactory UseSerilog(this LoggerFactory factory,Action<SerilogOption> SerilogAction)
        {
           // SerilogLoggerFactory
           //factory.AddSerilog(d);
            return factory;
        }
    }
}
