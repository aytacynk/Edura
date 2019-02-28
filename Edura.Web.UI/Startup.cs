using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Edura.Web.UI
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            // MIDDLEWARE işlemler: Akan giden bir süreç içerisinde belli işlemleri osüreç içerisine entegre ediyoruz. Burda MVC ekliyoruz.

            // MVC Framework eklenir.
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //wwwroot klasorunu dışarıya açmış oluyoruz.
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
