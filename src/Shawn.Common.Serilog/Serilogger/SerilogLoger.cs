using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Serilog;
using Serilog.Events;
using Shawn.Common.Ioc.Logging;

namespace Shawn.Common.Serilog
{
    public class SerilogLoger:ICommonLogger
    {
        private readonly ILogger _serilog;

        private string _strTemplate;

        public SerilogLoger(string strTemplate,string path)
        {
            _strTemplate = strTemplate;

            _serilog = new LoggerConfiguration()
                .WriteTo.File(path,
                    shared: true,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 6,
                    outputTemplate: strTemplate
                    , restrictedToMinimumLevel: LogEventLevel.Error)
                .CreateLogger();
        }
        public void Debug(string message)
        {
            throw new NotImplementedException();
        }

        public void Debug(Func<string> messageFactory)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(Exception exception, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(Func<string> messageFactory)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(Exception exception, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(Func<string> messageFactory)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(Exception exception, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }

        public void Warn(Func<string> messageFactory)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(Exception exception, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(Func<string> messageFactory)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(Exception exception, string format, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
