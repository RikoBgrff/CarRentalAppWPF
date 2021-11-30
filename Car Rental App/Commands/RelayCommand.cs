using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Car_Rental_App.Command
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            if (execute == null)
            {
                throw new NullReferenceException();
            }
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(object v)
        {
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute.Invoke(parameter);
        }
        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}