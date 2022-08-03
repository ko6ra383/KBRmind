using Microsoft.Extensions.DependencyInjection;

namespace KBRmind.ViewModels
{
    internal static class ViewModelRegistrator
    {
        public static IServiceCollection AddViews(this IServiceCollection services) => services
           .AddSingleton<MainViewModel>()
        ;
    }
}
