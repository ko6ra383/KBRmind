using KBRmind.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace KBRmind.Services
{
    internal static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
           .AddTransient<IDataService, DataService>()
        ;
    }
}
