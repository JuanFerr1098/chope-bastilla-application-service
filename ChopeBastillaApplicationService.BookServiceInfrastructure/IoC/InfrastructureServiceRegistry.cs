using ChopeBastillaApplicationService.BookServiceDomain.Repository;
using ChopeBastillaApplicationService.BookServiceInfrastructure.Adapter;
using ChopeBastillaApplicationService.BookServiceInfrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChopeBastillaApplicationService.BookServiceInfrastructure.IoC
{
    public static class InfrastructureServiceRegistry
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ChopeBastillaEFContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));
            services.AddSingleton<IBookRepository, BookRepositoryAdapter>();
            return services;
        }
    }
}
