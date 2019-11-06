using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Shawn.Common.Ioc.Logging;

namespace Test.WebApp.Service
{
    public class testlog
    {
        public string User { get; set; }
    }
    public class TestAppService:ITestAppService
    {
        public Serilog.ILogger _logger;

        public ILogger<TestAppService> _ZidLogger;

        public TestAppService(Serilog.ILogger log,ILogger<TestAppService> ZidLogger)
        {
            _logger = log;
            _ZidLogger = ZidLogger;
        }

        public string ttt()
        {

            _logger.Error("222222222");

           var logobj= new testlog
            {
                User = "444545Shawn"
            };

            _logger.Error(new Exception("sdsds"),"test", logobj);


            return "sssdd";
            }
    }
}
