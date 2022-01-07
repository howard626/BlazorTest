using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Stores
{
    public class ActionDispatcher : IActionDispatcher
    {
        private Action<IAction> _registeredActionHandler;

        public void Subscript(Action<IAction> actionHandler)
        {
            _registeredActionHandler += actionHandler;
        }

        public void Unsubscript(Action<IAction> actionHandler)
        {
            _registeredActionHandler -= actionHandler;
        }

        public void Dispatch(IAction action)
        {
            _registeredActionHandler?.Invoke(action);
        }
    }
}
