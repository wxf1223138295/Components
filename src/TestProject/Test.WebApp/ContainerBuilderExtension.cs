using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Test.WebApp.Service;

namespace Test.WebApp
{
    public static class ContainerBuilderExtension
    {
        public static ContainerBuilder AddMyServices(this ContainerBuilder build)
        {
            build.RegisterType<TestAppService>().As<ITestAppService>();
            return build;
        }
    }
}
