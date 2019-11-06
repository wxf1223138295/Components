using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Text;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using Serilog.Sinks.SystemConsole.Themes;
using Shawn.Common.Ioc.Logging;
using ILogger = Serilog.ILogger;

namespace Shawn.Common.Serilog
{
    public class SerilogLoger
    {
        public static ILogger CreateSerilog(string templateStr, string pathname,string logconnectstr,string tablename,LogEventLevel sqllogminlevel)
        {
            var columnOptions = new ColumnOptions // 自定义字段
            {
                AdditionalDataColumns = new Collection<DataColumn>
                {
                    new DataColumn {DataType = typeof (string), ColumnName = "User"}
                }
            };
            Log.Logger = new LoggerConfiguration()
                .Enrich.WithProperty("SourceContext", null)
                .WriteTo.MSSqlServer(logconnectstr, tablename,columnOptions: columnOptions, restrictedToMinimumLevel: sqllogminlevel,autoCreateSqlTable:true)
                .WriteTo.File(pathname,
                    shared: true,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 6,
                    outputTemplate: templateStr,
                    restrictedToMinimumLevel: LogEventLevel.Information)
                .WriteTo.Console(theme:AnsiConsoleTheme.Code, outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();


            var strs = "User: {User}";
            object[] para = new object[] {"Shawn" };

           

            Log.Logger.Error(strs, para);

         
            return Log.Logger;
        }
     
    }
}
