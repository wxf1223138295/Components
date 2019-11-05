using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Shawn.Common.Ioc.Logging
{
    /// <summary>
    /// 集成依赖注入框架
    /// </summary>
    public interface ICommonLogger
    {
        void Debug(string message);
        void Debug(Func<string> messageFactory);
        void Debug(string message, Exception exception);
        void DebugFormat(string format, params Object[] args);
        void DebugFormat(Exception exception, string format, params Object[] args);
        void Error(string message);
        void Error(Func<string> messageFactory);
        void Error(string message, Exception exception);
        void ErrorFormat(string format, params Object[] args);
        void ErrorFormat(Exception exception, string format, params Object[] args);

        void Info(string message);
        void Info(Func<string> messageFactory);
        void Info(string message, Exception exception);
        void InfoFormat(string format, params Object[] args);
        void InfoFormat(Exception exception, string format, params Object[] args);

        void Warn(string message);
        void Warn(Func<string> messageFactory);
        void Warn(string message, Exception exception);
        void WarnFormat(string format, params Object[] args);
        void WarnFormat(Exception exception, string format, params Object[] args);

        void Fatal(string message);
        void Fatal(Func<string> messageFactory);
        void Fatal(string message, Exception exception);
        void FatalFormat(string format, params Object[] args);
        void FatalFormat(Exception exception, string format, params Object[] args);
    }
}
