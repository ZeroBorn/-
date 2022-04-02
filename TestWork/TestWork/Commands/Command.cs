using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestWork.Commands
{
    public abstract class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        protected Action<object> _command;
        protected Predicate<object> _predicate;

        public virtual bool CanExecute(object? parameter)
        {
            if (_predicate == null)
                return true;
            
            return _predicate(parameter);
        }

        public virtual void Execute(object? parameter)
        {
            _command?.Invoke(parameter);
        }
    }
}
