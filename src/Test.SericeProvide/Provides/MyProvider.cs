using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.SericeProvide.Provides
{
    public class MyProvider:IServiceProvider
    {
        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}
