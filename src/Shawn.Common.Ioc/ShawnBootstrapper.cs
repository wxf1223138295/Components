﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Shawn.Common.Ioc.IocObject;
using Shawn.Common.Ioc.Options;

namespace Shawn.Common.Ioc
{
    public class ShawnBootstrapper
    {
        public IIocManager IocManager { get; }

        public IServiceProvider ServiceProvider { get; private set; }

        public static ShawnBootstrapper Create(Action<ShawnBootOptions> optionsAction, IServiceCollection iServiceCollection)
        {
            return new ShawnBootstrapper(optionsAction, iServiceCollection);
        }

        private ShawnBootstrapper(Action<ShawnBootOptions> optionsAction, IServiceCollection iServiceCollection)
        {
            var options = new ShawnBootOptions(iServiceCollection);
            //初始化Option对象。
            optionsAction?.Invoke(options);

            IocManager = options._IocManager;

        }

        public void SetServiceProvide(IServiceProvider _provider)
        {
            ServiceProvider = _provider;
        }

    }
}
