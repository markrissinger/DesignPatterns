using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Memento
{
    public class Originator
    {
        public Originator() 
        {
            _state = "initialized";
        }
        
        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public Memento GetMemento()
        {
            return new Memento(_state);
        }

        public void RestoreMemento(Memento previousMemento)
        {
            _state = previousMemento.State;
        }
    }
}
