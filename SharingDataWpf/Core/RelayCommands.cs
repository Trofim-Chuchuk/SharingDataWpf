using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SharingDataWpf.Core {
    internal class RelayCommands:ICommand {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;

        public RelayCommands(Action<object> Execute, Func<object, bool> CanExecute = null) {
            _Execute = Execute;
            _CanExecute = CanExecute;
        }

        public event EventHandler CanExecuteChanged {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public  bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public  void Execute(object parameter) {
           _CanExecute?.Invoke(parameter);
        }

    }
}
