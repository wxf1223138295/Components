using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.XPath;
using Shawn.Common.Ioc.Logging;

namespace Shawn.Common.Serilog
{
    public class SerilogFactory : ICommonLoggerFactory
    {
        public ICommonLogger Create(string pathname = "", string templateStr = "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff}] level: {Level:u4}, {Message:l}{NewLine}")
        {
            if (string.IsNullOrEmpty(pathname))
            {
               var directory = AppDomain.CurrentDomain.BaseDirectory;

               pathname = Path.Combine($"{directory}", "Logs", $"log.txt");
            }

            return new SerilogLoger(templateStr, pathname);
        }
    }
}
