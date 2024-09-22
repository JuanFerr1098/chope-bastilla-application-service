using ChopeBastillaApplicationService.BookServiceApplicationDomain.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ChopeBastillaApplicationService.BookServiceApplicationDomain.IoC
{
    public static class ApplicationServiceRegistry
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services) 
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
