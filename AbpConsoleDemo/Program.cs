using System;
using Microsoft.Extensions.DependencyInjection;
namespace AbpConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var appliaction = Volo.Abp.AbpApplicationFactory.Create<AppModule>())
            {
                appliaction.Initialize();


                var testService = appliaction.ServiceProvider.GetService<TestService>();


                testService.SayHello();
            }

            Console.WriteLine("按任意键停止应用!");
            Console.ReadLine();
        }
    }
}
