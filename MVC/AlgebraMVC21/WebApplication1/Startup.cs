using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDirectoryBrowser();
        }
       

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // dependency injection
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseDefaultFiles(); // ovo se mora pozvati PRIJE usestaticfiles()
            app.UseFileServer(enableDirectoryBrowsing: true);
            // default wwwroot
            // app.UseStaticFiles();


            // ukoliko ne želimo defaultni folder wwwroot
            // onda ovo dolje

            app.UseStaticFiles(new StaticFileOptions // mapiranje da uopæe možemo koristiti statièke fileove
                {
                    FileProvider = new PhysicalFileProvider(
                    Path.Combine(env.ContentRootPath, "MyStaticFiles")),
                    RequestPath = "/StaticFiles" //na ovu rutu mapiramo gornji folder 'MyStaticFiles'
                });

            // Ovo koristimo kada želimo I directory browsing I index.htm defaultne stranice
            app.UseFileServer(new FileServerOptions
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(env.ContentRootPath, "MyStaticFiles")),
                RequestPath = "/StaticFiles",
                EnableDirectoryBrowsing = true
            });

            //// Ukoliko želimo browsati po folderu
            //app.UseDirectoryBrowser(new DirectoryBrowserOptions // te statièke fileove možemo browseati
            //{
            //    FileProvider = new PhysicalFileProvider(
            //    Path.Combine(env.ContentRootPath, "MyStaticFiles")),
            //    RequestPath = "/StaticFiles"
            //});




            app.UseRouting();

            app.UseEndpoints(endpoints => // endpoint mapirane adrese
            {
                endpoints.MapGet("/", async context => // mapirana ruta
                {
                    await context.Response.WriteAsync("<b>Hello World!</b>"); // mapiran odgovor
                });
                endpoints.MapGet("/123/", async context =>
                {
                    await context.Response.WriteAsync("Dobar dan 123 ");
                });
            });
        }
    }
}
