using System;
using System.Collections.Generic;
using System.Text;

namespace AbpConsoleDemo
{
    public class TestService : Volo.Abp.DependencyInjection.ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("你好 于显野");

        }

    }
}
