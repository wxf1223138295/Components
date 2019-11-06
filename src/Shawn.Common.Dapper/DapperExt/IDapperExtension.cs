using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shawn.Common.Dapper.DapperExt
{
    public interface IDapperExtension
    {
        Task<IEnumerable<T>> GetAllTask<T>() where T : class;
    }
}
