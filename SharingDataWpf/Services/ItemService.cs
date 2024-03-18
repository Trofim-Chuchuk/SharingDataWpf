using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingDataWpf.Services;

public interface IItemService {
    public ObservableCollection<string> Items { get; set; }
    void AddItem();
}
public class ItemService : IItemService {
    public ObservableCollection<string> Items { get; set;} =new ();

    public void AddItem() {
       Items.Add("Item");
    }
}
