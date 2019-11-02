using System;
using System.Collections.Generic;
using System.Text;
using Shawn.Common.Ioc.IocObject;
using Shawn.Common.Ioc.Options;

namespace Shawn.Common.Ioc
{
    public class ShawnBootstrapper
    {
        public IIocManager IocManager { get; }

        public static ShawnBootstrapper Create(Action<ShawnBootOptions> optionsAction)
        {
            return new ShawnBootstrapper(optionsAction);
        }

        private ShawnBootstrapper(Action<ShawnBootOptions> optionsAction)
        {
            var options = new ShawnBootOptions();
            //初始化Option对象。
            optionsAction?.Invoke(options);

            IocManager = options._IocManager;
        }
    }
}
