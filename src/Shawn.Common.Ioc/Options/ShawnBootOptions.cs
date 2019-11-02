using System;
using System.Collections.Generic;
using System.Text;
using Shawn.Common.Ioc.IocObject;

namespace Shawn.Common.Ioc.Options
{
    public class ShawnBootOptions
    {
        public ShawnBootOptions()
        {
            _IocManager = IocManager.Instance;
        }

        public IIocManager _IocManager { get; set; }


    }
}
