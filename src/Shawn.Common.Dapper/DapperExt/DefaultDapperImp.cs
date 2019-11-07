using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Shawn.Common.Ioc.AccessorDependencyInjection;

namespace Shawn.Common.Dapper.DapperExt
{
    public class DefaultDapperImp: DapperExtension
    {
        public DefaultDapperImp(IObjectAccessor<DapperOptions> objectAccessor) : base(objectAccessor?.Value.DefaultConnectStrName)
        {
        }
    }
}
