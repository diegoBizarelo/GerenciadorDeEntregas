using Entregas.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entregas.CrossCutting.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencias(this IServiceCollection services)
        {
            services.AddScoped<EntregasContext>();

            return services;
        }
    }
}
