using SharingDataWpf.Core;
using SharingDataWpf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingDataWpf.MVVM.ViewModels
{
    public class MainViewModel : ViewModelBase {
        private readonly IWindowManager _windowManager;
        private readonly ViewModelLocator _viewModelLocator;

        public IItemService ItemService { get;  set; }

        public RelayCommands OpenSettingWindowCommand { get; set; }

        public MainViewModel(IItemService itemService,IWindowManager windowManager,ViewModelLocator viewModelLocator) {
            _windowManager=windowManager;
            _viewModelLocator=viewModelLocator;
            ItemService = itemService;


            OpenSettingWindowCommand =
                new RelayCommands((o) => { _windowManager.ShowWindow(_viewModelLocator.SettingsViewModel); }, (o)=>true);


        }
    }
}
