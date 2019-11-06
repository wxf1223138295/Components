using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using AutofacSerilogIntegration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Extensions.Logging;
using Shawn.Common.Ioc.Options;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Shawn.Common.Serilog
{
    public static class ShawnBootOptionsSerilogExtensions
    {
        public static ShawnBootOptions UseSerilog(this ShawnBootOptions options,Action<SerilogOption> SerilogAction)
        {
        
            var logger = new SerilogFactory().Create(SerilogAction);

            options._IocManager.BuilderContainer.RegisterLogger(logger,autowireProperties:true);

            options._iServiceCollection.AddSingleton(new SerilogLoggerFactory(logger));

            
            return options;
        }
    }
}
