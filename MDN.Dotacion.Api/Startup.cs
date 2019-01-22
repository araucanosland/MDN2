using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDN.Dotacion.Api.Data;
using MDN.Dotacion.Api.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MDN.Dotacion.Api
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
            /*App Db Context */
            services.AddDbContext<DotacionDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DotacionConnectionString"),
                x => x.MigrationsHistoryTable("__DotacionMigrationsHistory", "dotacion")));

            /*Repository Pattern implementation*/
            services.AddTransient<IDotacionAsignada, DotacionAsignadaImpl>();
            services.AddTransient<IDotacionAutorizada, DotacionAutorizadaImpl>();

            /*O*/
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(ConfigureJson);
        }

        private void ConfigureJson(MvcJsonOptions obj)
        {
            obj.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
                builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()
                );

            app.UseMvc();
        }
    }
}
