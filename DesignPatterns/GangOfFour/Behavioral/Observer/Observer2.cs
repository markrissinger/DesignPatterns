using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Observer
{
    public class Observer2 : IObserver
    {
        public Observer2(string name)
        {
            _name = name;
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            protected set
            {
                _name = value;
            }
        }

        private int _integer;
        public int Integer
        {
            get
            {
                return _integer;
            }
        }

        public void Update(int i)
        {
            _integer = i;
        }
    }
}
