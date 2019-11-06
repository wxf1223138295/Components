using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Shawn.Common.Dapper.DapperExt
{
    public class DefaultDapperImp: DapperExtension
    {
        public DefaultDapperImp(IDbConnectFactory factory) : base(factory)
        {
        }
    }
}
