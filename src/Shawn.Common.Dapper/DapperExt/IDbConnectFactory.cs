using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Shawn.Common.Dapper.DapperExt
{
    public interface IDbConnectFactory
    {
        IDbConnection iDbConnection { get; set; }

    }
}
