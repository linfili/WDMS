﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WDMS.Model
{
    public class DeletgateCommand<T> : ICommand
    {
       
            private readonly Action<T> _executeMethod = null;
            private readonly Func<T, bool> _canExecuteMethod = null;

            public DeletgateCommand(Action<T> executeMethod)
                : this(executeMethod, null)
            { }

            public DeletgateCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
            {
                if (executeMethod == null)
                    throw new ArgumentNullException("executeMetnod");
                _executeMethod = executeMethod;
                _canExecuteMethod = canExecuteMethod;
            }

            #region ICommand 成员
            /// <summary>
            ///  Method to determine if the command can be executed
            /// </summary>
            public bool CanExecute(T parameter)
            {
                if (_canExecuteMethod != null)
                {
                    return _canExecuteMethod(parameter);
                }
                return true;

            }

            /// <summary>
            ///  Execution of the command
            /// </summary>
            public void Execute(T parameter)
            {
                if (_executeMethod != null)
                {
                    _executeMethod(parameter);
                }
            }

            #endregion


            event EventHandler ICommand.CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }

            #region ICommand 成员

            public bool CanExecute(object parameter)
            {
                if (parameter == null && typeof(T).IsValueType)
                {
                    return (_canExecuteMethod == null);

                }

                return CanExecute((T)parameter);
            }

            public void Execute(object parameter)
            {
                Execute((T)parameter);
            }

            #endregion
        
    }
}
