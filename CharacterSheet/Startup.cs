using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterSheet.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CharacterSheet
{
    public class Startup
    {

        private readonly IConfiguration _config;
        private readonly IHostingEnvironment _env;

        public Startup(IConfiguration config, IHostingEnvironment env)
        {
            _config = config;
            _env = env;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {


            //Add MVC framework
            services.AddMvc();

            services.AddTransient<IMailService, NullMailService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseNodeModules(env);
            app.UseStaticFiles();


            app.UseMvc(routes =>
               {
                   routes.MapRoute(
                        name: "Default",
                        template: "{controller=Home}/{action=Index}/{id?}"
                        );
               }
            );

        }
    }
}
