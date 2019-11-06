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
        public static Logger CreateSerilog(string templateStr, string pathname,string logconnectstr,string tablename,LogEventLevel sqllogminlevel)
        {
            Logger _serlog = new LoggerConfiguration()
                .WriteTo.Console()
                //.WriteTo.MSSqlServer(logconnectstr,tablename,null,sqllogminlevel,autoCreateSqlTable:true)
                .WriteTo.File(pathname,
                    shared: true,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 6,
                    outputTemplate: templateStr
                    , restrictedToMinimumLevel: LogEventLevel.Error)
                .CreateLogger();
            return _serlog;
        }
     
    }
}
