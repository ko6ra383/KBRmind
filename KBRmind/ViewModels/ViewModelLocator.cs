using Microsoft.Extensions.DependencyInjection;

namespace KBRmind.ViewModels
{
    internal class ViewModelLocator
    {
        public MainViewModel MainViewModel => App.Services.GetRequiredService<MainViewModel>();
    }
}
