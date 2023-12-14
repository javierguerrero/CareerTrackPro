using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ms.web.domain.Interfaces;
using ms.web.infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.web.infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Inyección de dependencias de servicios personalizados
            //services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped(typeof(IAuthentication), typeof(Authentication));


            return services;
        }
    }
}
