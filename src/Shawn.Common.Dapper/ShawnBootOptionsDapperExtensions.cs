using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Shawn.Common.Dapper.DapperExt;
using Shawn.Common.Ioc.Options;

namespace Shawn.Common.Dapper
{
    public static class ShawnBootOptionsDapperExtensions
    {
        public static ShawnBootOptions UseDapper(this ShawnBootOptions options, Action<SerilogOption> SerilogAction)
        {
            //创建dbconnection
            options._IocManager.BuilderContainer
                .RegisterType<DbConnectFactory>()
                .InstancePerLifetimeScope()
                .As<IDbConnectFactory>();

            options._IocManager.BuilderContainer
                .RegisterType<DefaultDapperImp>()
                .InstancePerLifetimeScope()
                .As<IDapperExtension>();

            return options;
        }
    }
}
