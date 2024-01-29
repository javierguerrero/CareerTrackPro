using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ms.jobapplications.infrastructure.Data;

namespace ms.jobapplications.infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Inyección de dependencias de servicios personalizados
            //services.AddScoped<IItemRepository, ItemRepository>();


            // Entity Framework
            var connectionString = $"Server={configuration.GetConnectionString("JobaApplicationDB:HostName")};" +
                                            $"Database={configuration.GetConnectionString("JobaApplicationDB:Catalogue")};" +
                                            $"User ID={configuration.GetConnectionString("JobaApplicationDB:User")};" +
                                            $"Password={configuration.GetConnectionString("JobaApplicationDB:Password")};" +
                                            $"Encrypt=False;MultipleActiveResultSets=True;";
            services.AddDbContext<JobApplicationContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
