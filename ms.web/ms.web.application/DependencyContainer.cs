using AutoMapper;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ms.web.application.HttpCommunications;
using ms.web.application.Mapper;
using Refit;
using System.Reflection;

namespace ms.web.application
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // MediatR
            services.AddMediatR(Assembly.GetExecutingAssembly());

            // AutoMapper
            var automapperConfig = new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.AddMaps(typeof(AdminDashboardProfile).Assembly);
            });
            IMapper mapper = automapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            // Authentication API
            services.AddRefitClient<IAuthtenticationApiCommunication>()
                    .ConfigureHttpClient(c => c.BaseAddress = new Uri(configuration.GetSection("Communication:External:AuthenticationApiUrl").Value));

            return services;
        }
    }
}