using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FrontendSamples
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
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            //Canonical url - Канонический адрес страницы https://github.com/creativcode-ru/razor-pages-examples/blob/master/frontend/canonical-url.md
            var rewriteOptions = new RewriteOptions()
                .AddRedirect("(.*)(/index/*)$", "$1", 301)  //убираем везде дубликат страницы по умолчанию;
                .AddRedirect("(.*)/$", "$1", 301);    //убираем слеж в конце адреса для других страниц 
               
            app.UseRewriter(rewriteOptions); //https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/url-rewriting?view=aspnetcore-3.1


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
