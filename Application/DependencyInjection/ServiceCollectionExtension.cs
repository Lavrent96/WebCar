using Application.Services.Implementations;
using Application.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static void AddWebCarApplicationDI(this IServiceCollection services)
        {

            // Services 
        //    services.AddScoped<ICarModelService, CarModelService>();
            services.AddScoped<ICarBrandService, CarBrandService>();
            services.AddScoped<ITireService, TireService>();
        }
    }
}
