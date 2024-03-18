using Microsoft.Extensions.DependencyInjection;
using SharingDataWpf.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingDataWpf.Services {
    public class ViewModelLocator {
        private readonly IServiceProvider _serviceProvider;

        public ViewModelLocator(IServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
        }


        public MainViewModel MainViewModel => _serviceProvider.GetRequiredService<MainViewModel>();
        public SettingViewModel SettingsViewModel => _serviceProvider.GetRequiredService<SettingViewModel>();
    }
}
