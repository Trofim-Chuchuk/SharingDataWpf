using Microsoft.Extensions.DependencyInjection;
using SharingDataWpf.MVVM.ViewModels;
using SharingDataWpf.Services;
using System.Configuration;
using System.Data;
using System.Windows;

namespace SharingDataWpf {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private readonly IServiceCollection _services=new ServiceCollection();
        private readonly IServiceProvider _serviceProvider;
        public App() {
            _services.AddSingleton<MainViewModel>();
            _services.AddSingleton<SettingViewModel>();
            _services.AddSingleton<ViewModelLocator>();

            _services.AddSingleton<WindowMapper>();
            _services.AddSingleton<IWindowManager, WindowManager>();
            _services.AddSingleton<IItemService, ItemService>();

            _serviceProvider = _services.BuildServiceProvider();

        }

        protected override void OnStartup(StartupEventArgs e) {
            var windowManager=_serviceProvider.GetRequiredService<IWindowManager>(); 
            windowManager.ShowWindow(_serviceProvider.GetRequiredService<MainViewModel>());
            base.OnStartup(e);
        }


    }
   
}