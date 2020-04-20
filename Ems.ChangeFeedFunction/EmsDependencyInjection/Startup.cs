using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

using EMS.Common.ServerConfig;
using EMS.SqlRepository.DbRepository;
using EMS.DbModelRepository.Models;
using EMS.ManagerRepository.Manager;
using EMS.ManagerRepository.FactoryRepository;
using EMS.DbModelRepository;
using Ems.DbModelRepository;

[assembly: FunctionsStartup(typeof(Ems.ChangeFeedFunction.EmsDependencyInjection.Startup))]
namespace Ems.ChangeFeedFunction.EmsDependencyInjection
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {

            builder.Services.AddDbContext<EmsDbContext>(option =>
                    {
                        option.UseSqlServer(ConfigHelper.GetConnectionnString);
                    });
            builder.Services.AddScoped<EmsDataCalculateManager>();
            builder.Services.AddScoped<EmsBlockManager>();
            builder.Services.AddScoped<Factory>();
            builder.Services.AddScoped<EmsPM520LManager>();
            builder.Services.AddTransient(typeof(IEmsRepository<EmsMaster>), typeof(EmsRepository<EmsMaster>));
            builder.Services.AddTransient(typeof(IEmsRepository<Block>), typeof(EmsRepository<Block>));
            builder.Services.AddTransient(typeof(IEmsRepository<PM520L>), typeof(EmsRepository<PM520L>));
        }
    }
}
