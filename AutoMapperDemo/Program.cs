using AutoMapper;
using System;

namespace AutoMapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var configuration = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<TestA, TestB>();
                cfg.CreateMap<TestA, TestB>().ForMember(x => x.Name, a => { a.MapFrom(b => b.MyName); });
            });
            // only during development, validate your mappings; remove it before release
            configuration.AssertConfigurationIsValid();
            // use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            var mapper = configuration.CreateMapper();


            TestA testA = new TestA() { Id = 10, MyName = "yxy" };

            //AutoMapperConfig.RegisterMappings();


            var testB = mapper.Map<TestB>(testA);
            //var barDto = mapper.Map<BarDto>(bar);
        }
    }



}



public class TestA
{
    public int Id { get; set; }

    public string MyName { get; set; }

}


public class TestB
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string MyName { get; set; }


}

