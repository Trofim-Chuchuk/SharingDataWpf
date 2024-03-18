using SharingDataWpf.MVVM.ViewModels;
using SharingDataWpf.MVVM.Views;
using System.Windows;

namespace SharingDataWpf.Services {
    public class WindowMapper {
        private readonly Dictionary<Type, Type> mappings = new();

        public WindowMapper() {
            RegisterMapping<MainViewModel,MainWindow>();
            RegisterMapping<SettingViewModel,SettingWindow>();

        }

        public void RegisterMapping<TViewModel, TWindow>()
            where TViewModel :  ViewModelBase where TWindow : Window {
            mappings[(typeof(TViewModel))] = typeof(TWindow);
        }

        public Type GetWindowTypeForViewModel(Type viewModelType) {
            mappings.TryGetValue(viewModelType, out var windowType);
            return windowType;
        }
    }
}
