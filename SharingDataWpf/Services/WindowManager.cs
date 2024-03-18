using SharingDataWpf.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SharingDataWpf.Services;

public interface IWindowManager {
    void ShowWindow(ViewModelBase viewModel);
    void CloseWindow();
}

public class WindowManager : IWindowManager {
    private readonly WindowMapper windowMapper;
    public WindowManager(WindowMapper windowMapper) { 

        this.windowMapper = windowMapper;
    }
    public void CloseWindow() {
        MessageBox.Show("woho");
    }

    public void ShowWindow(ViewModelBase viewModel) {
        var windowType=windowMapper.GetWindowTypeForViewModel(viewModel.GetType());
        if (windowType != null) {
            var window=Activator.CreateInstance(windowType)as Window;
            window.DataContext = viewModel;
            window.Show();
            window.Closed += (sender,args ) => CloseWindow();
        }
    }

}
