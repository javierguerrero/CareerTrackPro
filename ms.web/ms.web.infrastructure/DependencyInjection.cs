using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ms.web.infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Inyección de dependencias de servicios personalizados
            //services.AddScoped<IItemRepository, ItemRepository>();

            return services;
        }
    }
}