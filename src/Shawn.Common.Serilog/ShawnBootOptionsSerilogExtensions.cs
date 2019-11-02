using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Shawn.Common.Ioc.Logging;
using Shawn.Common.Ioc.Options;

namespace Shawn.Common.Serilog
{
    public static class ShawnBootOptionsSerilogExtensions
    {
        public static ShawnBootOptions UseSerilog(this ShawnBootOptions configuration)
        {
            configuration._IocManager.BuilderContainer
                .RegisterType<SerilogFactory>()
                .As<ICommonLoggerFactory>();
               // .UsingConstructor(typeof(string),typeof(string));
            return configuration;
        }
    }
}
