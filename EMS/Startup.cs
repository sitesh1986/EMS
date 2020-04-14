using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.AzureGraphRepository;
using EMS.ManagerRepository.FactoryRepository;
using EMS.ManagerRepository.Manager;
using EMS.Models;
using EMS.ModelsRepository.Models;
using EMS.SqlRepository.DbRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
namespace EMS
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
            services.AddDbContext<EmsContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("DataConnection"));
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EMS", Version = "v1" });
            });
            services.AddScoped<EmsDataCalculateManager>();
            services.AddScoped<EmsBlockManager>();
            services.AddScoped<EmsDataCalculateManager>();
            services.AddScoped<EmsBlockManager>();
            services.AddScoped<Factory>();
            services.AddScoped<EmsPM520LManager>();
            services.AddScoped<CustomerManager>();
            services.AddTransient(typeof(IEmsRepository<EmsMaster>), typeof(EmsRepository<EmsMaster>));
            services.AddTransient(typeof(IEmsRepository<Block>), typeof(EmsRepository<Block>));
            services.AddTransient(typeof(IEmsRepository<PM520L>), typeof(EmsRepository<PM520L>));
            services.AddTransient(typeof(IEmsRepository<Customer>), typeof(EmsRepository<Customer>));
            services.AddSingleton<B2CGraphClient>(new B2CGraphClient
               (Configuration["ClientId"],
               Configuration["ClientSecret"],
               Configuration["Tenant"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "EMS - EMS Management Integration API v1.0");
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
