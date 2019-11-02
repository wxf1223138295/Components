using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Shawn.Common.Ioc.CoreStart
{
    public class ShawnAutofacServiceProviderFactory: IServiceProviderFactory<ContainerBuilder>
    {
        private readonly ContainerBuilder _builder;
        private IServiceCollection _services;

        public ShawnAutofacServiceProviderFactory(ContainerBuilder builder)
        {
            _builder = builder;
        }
        public ContainerBuilder CreateBuilder(IServiceCollection services)
        {
            _services = services;
            _builder.Populate(services);

            return _builder;
        }

        public IServiceProvider CreateServiceProvider(ContainerBuilder containerBuilder)
        {
            return new AutofacServiceProvider(containerBuilder.Build());
        }
    }
}
