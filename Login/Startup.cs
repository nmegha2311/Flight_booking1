using Login_ManagerLayer;
using Login_RepoLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static Login_RepoLayer.Depotcontext;

namespace Login
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
            services.AddCors((options1) =>
            {
                options1.AddPolicy(name: "angularApplication", (builder) =>
                     {
                         builder.AllowAnyOrigin()
                         .AllowAnyHeader()
                         .AllowAnyMethod()
                         ;

                     });
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            var connectionString = Configuration.GetConnectionString("default");
            services.AddDbContext<Depotcontext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<Depotcontext>();
            services.AddScoped<Search>();
            services.AddScoped<Repo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
      
            app.UseCors("angularApplication");
            app.UseMvc();
        }
    }
}
