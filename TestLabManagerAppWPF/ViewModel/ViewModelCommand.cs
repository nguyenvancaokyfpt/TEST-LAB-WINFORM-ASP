using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestLabManagerAppWPF.ViewModel
{
    public class ViewModelCommand : ICommand
    {
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecutePredicate;

        // Constructor
        public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecutePredicate)
        {
            _executeAction = executeAction;
            _canExecutePredicate = canExecutePredicate;
        }

        // Constructor
        public ViewModelCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canExecutePredicate = null;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; } // add an anonymous method to the event
            remove { CommandManager.RequerySuggested -= value; } // remove an anonymous method from the event
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecutePredicate == null)
            {
                return true;
            }
            else
            {
                return _canExecutePredicate(parameter);
            }
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }
    }
}
