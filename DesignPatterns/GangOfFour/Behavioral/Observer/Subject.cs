using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Observer
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public List<IObserver> Observers
        {
            get 
            { 
                return _observers; 
            }
        }

        private int _flag;
        public int Flag
        {
            get
            {
                return _flag;
            }
            set
            {
                _flag = value;
                Notify(_flag);
            }
        }

        public void Notify(int i)
        {
            foreach (var observer in _observers)
            {
                observer.Update(i);
            }
        }

        public void Register(IObserver o)
        {
            _observers.Add(o);
        }

        public void Unregister(IObserver o)
        {
            _observers.Remove(o);
        }
    }
}
