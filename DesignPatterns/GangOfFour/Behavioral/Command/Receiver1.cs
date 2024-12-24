using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Command
{
    public class Receiver1 : IReceiver
    {
        public Receiver1()
        {
            _number = 10;

        }
        
        private int _number;
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public void OptionalPostProcessing()
        {
            // Do something
        }

        public void OptionalPreProcessing()
        {
            // Do something
        }

        public int AddOne()
        {
            _number++;
            return _number;
        }

        public int SubtractOne()
        {
            if (_number > 10)
            {
                _number--;
            }
            return _number;
        }
    }
}
