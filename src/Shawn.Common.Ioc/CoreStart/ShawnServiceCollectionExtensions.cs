using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Shawn.Common.Ioc.Options;

namespace Shawn.Common.Ioc.CoreStart
{
    public static class ShawnServiceCollectionExtensions
    {
        public static IServiceProvider AddShawnService(this IServiceCollection services, Action<ShawnBootOptions> optionsAction)
        {
            return null;
        }
    }
}
