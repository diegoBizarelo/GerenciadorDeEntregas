using Entregas.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entregas.CrossCutting.Configuration
{
    public static class ContextConfig
    {
        public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<EntregasContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("Entregas.API")));

            return services;
        }
    }
}
