using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Shawn.Common.Ioc.Logging;

namespace Test.WebApp.Service
{
    public class TestAppService:ITestAppService
    {
        private ILogger _logger;

        public TestAppService(ILogger logger)
        {
            _logger = logger;
        }

        public string ttt()
        {
            return "sssdd";
        }
    }
}
