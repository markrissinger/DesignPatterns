using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.ChainOfResponsibility
{
    public class EmailErrorHandler : IReceiver
    {
        public EmailErrorHandler(IReceiver nextReceiver)
        {
            _nextReceiver = nextReceiver;
        }

        private IReceiver _nextReceiver;
        public IReceiver NextReceiver
        {
            get { return _nextReceiver; }
        }

        public bool HandleMessage(Message message)
        {
            if (message.Text.Contains("Email"))
            {
                return true;
            }
            else
            {
                if (_nextReceiver != null)
                {
                    _nextReceiver.HandleMessage(message);
                }
            }
            return false;
        }
    }
}
