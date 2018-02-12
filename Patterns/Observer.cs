using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{

    interface IObservable
    {
        void Add(IObserver obs);
        void Remove(IObserver obs);

        void Notify();
    }

    interface IObserver
    {
        void HandleEvent();
    }

    class Observable: IObservable
    {
        internal delegate void StateChangeHandler();

        private event StateChangeHandler _onChange ;


        public void Add(IObserver obs)
        {
            _onChange += obs.HandleEvent;
        }

        public void Remove(IObserver obs)
        {
            _onChange -= obs.HandleEvent;
        }

        public void Notify()
        {
            _onChange();
        }
    }

    class Observer : IObserver
    {
        public void HandleEvent()
        {
            Console.WriteLine("Something happened to " + this.GetHashCode());
        }
    }

}
