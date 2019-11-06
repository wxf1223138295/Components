using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Shawn.Common.Ioc.Logging;
using ILogger = Serilog.ILogger;

namespace Shawn.Common.Serilog
{
    public class SerilogLoger
    {
        public Logger CreateSerilog(string templateStr, string pathname)
        {
            Logger sd = new LoggerConfiguration()
                .WriteTo.Console()
                //.WriteTo.MSSqlServer()
                .WriteTo.File(pathname,
                    shared: true,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 6,
                    outputTemplate: templateStr
                    , restrictedToMinimumLevel: LogEventLevel.Error)
                .CreateLogger();
            return sd;
        }
     
    }
}
