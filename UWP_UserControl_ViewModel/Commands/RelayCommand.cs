using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UWP_UserControl_ViewModel.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<object> executeAction;
        private Func<object, bool> canExecuteFunc;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            executeAction = execute;
            canExecuteFunc = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecuteFunc == null)
            {
                return true;
            }

            return canExecuteFunc.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            executeAction.Invoke(parameter);
        }
    }
}
