using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Shawn.Common.Dapper.DapperExt
{
    public class DbConnectFactory
    {
        public IDbConnection iDbConnection { get; set; }

        public void CreateDbConnection(string connectStr)
        {
            var connection = new SqlConnection(connectStr);
            iDbConnection = connection;
        }
    }
}
