using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console.Internal;
using Serilog;
using Serilog.Extensions.Logging;
using Shawn.Common.Ioc;
using Shawn.Common.Ioc.CoreStart;
using Shawn.Common.Ioc.Logging;
using Shawn.Common.Serilog;
using Test.WebApp.Service;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Test.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration, Serilog.ILogger log)
        {
            Configuration = configuration;
            _logger = log;
        }

        public Serilog.ILogger _logger;
        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


           

            services.AddLogging(p => p.AddConsole());

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            return services.AddShawnService(option =>
            {
                //添加自己的服务
               

                option.UseSerilog(p =>
                {
                    p.pathName = "";
                    p.strTempName = "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff}] level: {Level:u4}, {Message:l}{NewLine}";
                    p.logminEvent=Serilog.Events.LogEventLevel.Information;
                    p.logTableName="LogSerilog";
                    p.logConnectstr=Configuration.GetValue<string>("DefaultConnectStr");
                });


                option._IocManager.BuilderContainer.AddMyServices();

                

                //注入日志
            });

            //return services.BuildShawnServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider provider, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


            _logger.Debug("mesddds");


            //  var ser= (ITestAppService)provider.GetService(typeof(ITestAppService));

            //var boo=(ShawnBootstrapper) provider.GetService(typeof(ShawnBootstrapper));

            //  var t=ser.ttt();

            //var tty=boo.IocManager.iContainer.Resolve<ITestAppService>().ttt();
        }
    }
}
