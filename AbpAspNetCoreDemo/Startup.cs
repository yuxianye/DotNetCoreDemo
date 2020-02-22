using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AbpAspNetCoreDemo
{
    public class Startup
    {

        //public IServiceProvider ConfigureServices(IServiceCollection services)
        //{
        //    services.AddApplication<AppModule>();

        //    return services.BuildServiceProviderFromFactory();
        //}

        //public void Configure(IApplicationBuilder app)
        //{
        //    app.InitializeApplication();
        //}








        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //public void IServiceProvider(IServiceCollection services)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<AppModule>();
            services.AddMvcCore((ops) => { ops.EnableEndpointRouting = false; });
            //return services.BuildServiceProviderFromFactory();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.InitializeApplication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World! old");
                });
            });
        }
    }
}
