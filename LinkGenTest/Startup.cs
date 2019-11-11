using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LinkGenTest {
    public class Startup {


        public void ConfigureServices(IServiceCollection services) {
            services.AddRouting()
                .AddControllersWithViews().Services
                .AddSingleton<DummyDynamicRouteValueTransformer>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {


            app.UseRouting()
               .UseEndpoints(e => {
                    e.MapDynamicControllerRoute<DummyDynamicRouteValueTransformer>(
                          "{controller=Home}/{action=Index}"   
                     );
                });
        }
    }
}
