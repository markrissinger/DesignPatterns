using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Command
{
    public class Receiver2 : IReceiver
    {
        public Receiver2()
        {
            _number = 75;

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
            if (_number > 75)
            {
                _number--;
            }
            return _number;
        }
    }
}
