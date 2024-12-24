using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Command
{
    public class Command : ICommand
    {
        public Command(IReceiver receiver)
        {
            _receiver = receiver;
        }

        private IReceiver _receiver;
        public IReceiver Receiver 
        {
            get { return _receiver; }
            set { _receiver = value; }
        }

        public void Do()
        {
            _receiver.OptionalPreProcessing();
            _receiver.AddOne();
            _receiver.OptionalPostProcessing();
        }
        public void UnDo()
        {
            _receiver.OptionalPreProcessing();
            _receiver.SubtractOne();
            _receiver.OptionalPostProcessing();
        }
    }
}
