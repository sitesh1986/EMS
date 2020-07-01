using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EMS.ManagerRepository.FactoryRepository;
using EMS.ManagerRepository.Manager;
using EMS.DbModelRepository;
using EMS.DbModelRepository.Models;
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
using Ems.DbModelRepository;
using EMS.Filters;

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
            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<EmsDbContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("DataConnection"));
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
           
            services.AddAuthorization();
            services.AddSingleton<AssertPrivilege>(new  AssertPrivilege
              (Configuration["ClientId"]));
            services.AddScoped<EmsDataCalculateManager>();
            services.AddScoped<EmsMasterManager>();
            services.AddScoped<EmsDataCalculateManager>();
            services.AddScoped<EmsBlockManager>();
            services.AddScoped<Factory>();
            services.AddScoped<EmsPM520LManager>();
            services.AddScoped<CustomerManager>();
            services.AddScoped<PrivilegeManager>();
            services.AddScoped<ServiceBusManager>();
            services.AddScoped<EmailManager>();
            services.AddScoped<DeviceManager>();
            services.AddScoped<LoginManager>();
            services.AddScoped<ReportManager>();
            services.AddScoped<MeterManager>();
            services.AddTransient(typeof(IEmsRepository<EmsMaster>), typeof(EmsRepository<EmsMaster>));
            services.AddTransient(typeof(IEmsRepository<Block>), typeof(EmsRepository<Block>));
            services.AddTransient(typeof(IEmsRepository<PM520L>), typeof(EmsRepository<PM520L>));
            services.AddTransient(typeof(IEmsRepository<Customer>), typeof(EmsRepository<Customer>));
            services.AddTransient(typeof(IEmsRepository<CustomerPrivilege>), typeof(EmsRepository<CustomerPrivilege>));
            services.AddTransient(typeof(IEmsRepository<Privilige>), typeof(EmsRepository<Privilige>));
            services.AddTransient(typeof(IEmsRepository<DeviceModel>), typeof(EmsRepository<DeviceModel>));
            services.AddTransient(typeof(IEmsRepository<MetersModel>), typeof(EmsRepository<MetersModel>));
            services.AddTransient(typeof(IEmsRepository<CustomerMeter>), typeof(EmsRepository<CustomerMeter>));
            //services.AddSingleton<B2CGraphClient>(new B2CGraphClient
            //   (Configuration["ClientId"],
            //   Configuration["ClientSecret"],
            //   Configuration["Tenant"]));
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
            //app.UseCors(corsPolicyBuilder =>
            //corsPolicyBuilder.WithOrigins("http://localhost:3000", "https://raviprakashsingh.github.io")
            //.AllowAnyMethod()
            //.AllowAnyHeader()
            //);
            app.UseCors(corsPolicyBuilder =>
           corsPolicyBuilder.WithOrigins("http://localhost:3000")
           .AllowAnyMethod()
           .AllowAnyHeader()
           );

            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
