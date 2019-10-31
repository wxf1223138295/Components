using System;
using System.Collections.Generic;
using System.Text;

namespace Shawn.Common.Ioc.Logging
{
    public interface ICommonLoggerFactory
    {
        /// <summary>Create a logger with the given logger name.
        /// </summary>
        ICommonLogger Create(string name,string templateStr);
        /// <summary>Create a logger with the given type.
        /// </summary>
       // ICommonLogger Create(Type type, string templateStr);
    }
}
