using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Shawn.Common.Ioc.IocObject;

namespace Shawn.Common.Ioc.Options
{
    public class ShawnBootOptions
    {
        public IServiceCollection _iServiceCollection { get; set; }
        public ShawnBootOptions(IServiceCollection iServiceCollection)
        {
            _IocManager = IocManager.Instance;
            _iServiceCollection = iServiceCollection;
        }
       
        public IIocManager _IocManager { get; set; }
    }
}
