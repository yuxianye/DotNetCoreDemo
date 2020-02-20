using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AutoMapperWebApplicationDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //services.AddAutoMapper();
            //IServiceCollection services = new ServiceCollection();
            //services.AddTransient<ISomeService>(sp => new FooService(5));
            services.AddAutoMapper(System.Reflection.Assembly.GetExecutingAssembly());
            //services.AddAutoMapper(Assembly.Load("AutoMapperWebApplicationDemo"));
            // var _provider = services.BuildServiceProvider();
            //services.AddSingleton<IMapper>();
            // _provider.GetService<AutoMapper.IConfigurationProvider>().AssertConfigurationIsValid();
            //MapperConfiguration = new MapperConfiguration(;

            //services.AddAutoMapper(System.Reflection.Assembly.GetExecutingAssembly());

            //services.AddAutoMapper(System.Reflection.Assembly.GetExecutingAssembly());
            //            services.AddTransient<TestA>();
            //            services.AddAutoMapper(typeof(TestA).GetTypeInfo().Assembly
            //);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //var expression = app.UseAutoMapper();
            //expression.CreateMap<Foo, FoodDto>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public class TestProfile : Profile

    {

        public TestProfile()
        {
            CreateMap<TestA, TestADto>().ForMember(x => x.Name, a => { a.MapFrom(b => b.MyName); });
        }

    }









}
