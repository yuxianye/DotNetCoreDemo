using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace AutoMapperWebApplicationDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).ConfigureLogging(logging =>
     {
         logging.ClearProviders(); //移除已经注册的其他日志处理程序
         logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Debug); //设置最小的日志级别
     }).UseNLog();

        //  .ConfigureLogging(logging =>
        //{
        //      logging.ClearProviders();
        //      logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
        //  })
        //.UseNLog();  // NLog: Setup NLog for Dependency injection

    }
}
