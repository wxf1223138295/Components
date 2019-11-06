using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Shawn.Common.Dapper.DapperExt
{
    public abstract class DapperExtension : IDapperExtension 
    {
        private IDbConnection iDbConnection;
        protected DapperExtension()
        {

        }
        protected DapperExtension(IDbConnectFactory factory)
        {
            this.iDbConnection = factory.iDbConnection;
        }

        public async Task<IEnumerable<T>> GetAllTask<T>() where T:class
        {
            using (IDbConnection conn = iDbConnection)
            {
                var result = await conn.GetAllAsync<T>();
                return result;
            }
        }
    }
}
