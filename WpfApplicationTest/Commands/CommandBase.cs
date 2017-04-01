using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplicationTest.Commands
{
    public abstract class CommandBase<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Type argumentType = parameter.GetType();
            if (argumentType != typeof(T))
            {
                throw new ArgumentException($"Expected Type to Be {typeof(T).Name}, but was {argumentType.Name}", nameof(parameter));
            }

            Execute((T)parameter);
        }

        protected virtual void Execute(T parameter)
        {
            return;
        }
    }
}
