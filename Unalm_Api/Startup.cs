using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unalm_Api.Data;
using Microsoft.EntityFrameworkCore;

namespace Unalm_Api
{
    public class Startup
    {

        readonly string MisOrigenes = "misOrigenes";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //CORS
            services.AddCors(
                options =>
                    options.AddPolicy(
                        name: MisOrigenes,
                        builder => builder.WithOrigins(
                            "http://localhost:4200", //angular
                            "http://localhost:3000",  //react
                            "http://localhost:8080"  //vue
                        ).AllowAnyHeader().AllowAnyMethod()
                    )
            );


            services.AddControllers();

            services.AddDbContext<unalmContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("MySQLConn"), ServerVersion.Parse("8.0.25-mysql"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(MisOrigenes);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
