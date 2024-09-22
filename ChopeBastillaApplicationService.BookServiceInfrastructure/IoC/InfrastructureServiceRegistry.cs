using ChopeBastillaApplicationService.BookServiceDomain.Repository;
using ChopeBastillaApplicationService.BookServiceInfrastructure.Adapter;
using Microsoft.Extensions.DependencyInjection;

namespace ChopeBastillaApplicationService.BookServiceInfrastructure.IoC
{
    public static class InfrastructureServiceRegistry
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
        {
            services.AddSingleton<IBookRepository, BookRepositoryAdapter>();
            return services;
        }
    }
}
