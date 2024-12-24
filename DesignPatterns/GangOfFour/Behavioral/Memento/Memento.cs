using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Memento
{
    public class Memento
    {
        public Memento(string? state = null)
        {
            _state = state;
        }

        private string? _state;
        public string? State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
