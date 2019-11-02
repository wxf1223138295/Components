using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Shawn.Common.Ioc.Options;

namespace Shawn.Common.Ioc.CoreStart
{
    public static class ShawnServiceCollectionExtensions
    {
        public static IServiceCollection AddShawnService(this IServiceCollection services, Action<ShawnBootOptions> optionsAction)
        {
            var shawnBootstrapper = ShawnBootstrapper.Create(optionsAction);
            //services.AddOptions();
            services.AddSingleton(shawnBootstrapper);
    
            services.AddSingleton(
                (IServiceProviderFactory<ContainerBuilder>) new ShawnAutofacServiceProviderFactory(shawnBootstrapper
                    .IocManager.BuilderContainer));
            return services;
        }

        //public static IServiceProvider BuildShawnServiceProvider(this IServiceCollection services,
        //    Action<ContainerBuilder> optionsAction)
        //{

        //    var result = services.BuildServiceProvider();
        //}

    }
}
