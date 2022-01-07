using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Stores.CounterStore
{
    public class CounterState
    {
        public int Count { get; set; }

        public CounterState(int count)
        {
            Count = count;
        }
    }

    public class CounterStore
    {
        private CounterState _state;
        private readonly IActionDispatcher actionDispatcher;
        public CounterStore(IActionDispatcher actionDispatcher) 
        {
            _state = new CounterState(0);
            this.actionDispatcher = actionDispatcher;
            this.actionDispatcher.Subscript(HandleActions);
        }

        public CounterState GetState() 
        {
            return _state;
        }

        private void HandleActions(IAction action)
        {
            switch (action.Name)
            {
                case IncrementAction.INCREMENT:
                    IncrementCount();
                    break;
                case DecrementAction.DECREMENT:
                    DecrementCount();
                    break;
                default:break;
            }
        }

        public void IncrementCount()
        {
            var count = _state.Count;
            count++;
            _state = new CounterState(count);
            BroadcastStateChange();
        }

        public void DecrementCount()
        {
            var count = _state.Count;
            count--;
            _state = new CounterState(count);
            BroadcastStateChange();
        }

        private Action _listeners;

        public void AddStateChangeListener(Action listener)
        {
            _listeners += listener;
        }

        public void RemoveStateChangeListener(Action listener)
        {
            _listeners -= listener;
        }

        public void BroadcastStateChange()
        {
            _listeners.Invoke();
        }
    }
}
