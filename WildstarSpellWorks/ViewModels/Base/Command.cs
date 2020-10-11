using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace WildstarSpellWorks.ViewModels
{
    public class Command : ICommand
    {
        private Func<object, bool> _CanExecute;
        private Action _Execute;

        public event EventHandler CanExecuteChanged; //TODO: AA This is not currently used.

        public Command(Action execute, Func<object, bool> canExecute = null)
        {
            this._Execute = execute;
            this._CanExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_CanExecute == null)
                return true;
            
            return _CanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _Execute();
        }
    }
}
