using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using JetBrains.Annotations;
using Shawn.Common.Dapper.DapperExt;
using Shawn.Common.Ioc.AccessorDependencyInjection;
using Shawn.Common.Ioc.Options;

namespace Shawn.Common.Dapper
{
    public static class ShawnBootOptionsDapperExtensions
    {
        public static ShawnBootOptions UseDapper(this ShawnBootOptions options,[NotNull] Action<DapperOptions> dapperoptions)
        {
            DapperOptions obj=new DapperOptions();
            dapperoptions?.Invoke(obj);

            options._iServiceCollection.AddObjectAccessor<DapperOptions>(obj);

            options._IocManager.BuilderContainer
                .RegisterType<DefaultDapperImp>()
                .InstancePerLifetimeScope()
                .As<IDapperExtension>();

            return options;
        }
    }
}
