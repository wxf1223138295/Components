using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.XPath;
using Serilog;
using Shawn.Common.Ioc.Logging;

namespace Shawn.Common.Serilog
{
    public class SerilogFactory 
    {
        public ILogger Create(Action<SerilogOption> optins)
        {
            SerilogOption opt=new SerilogOption();
            optins?.Invoke(opt);

            if (string.IsNullOrEmpty(opt.pathName))
            {
               var directory = AppDomain.CurrentDomain.BaseDirectory;

               opt.pathName = Path.Combine($"{directory}", "Logs", $"log.txt");
            }
            return new SerilogLoger(opt.strTempName, opt.pathName);
        }
    }
}
