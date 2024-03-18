using SharingDataWpf.Core;
using SharingDataWpf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingDataWpf.MVVM.ViewModels
{
    public class SettingViewModel : ViewModelBase {
        public IItemService ItemService { get; set; }
        public RelayCommands AddItemCommand {  get; set; } 
        public SettingViewModel(IItemService itemsService) { 
            ItemService= itemsService;
            AddItemCommand = new RelayCommands(o => { ItemService.AddItem(); }, o => true);
        }
    }
}
