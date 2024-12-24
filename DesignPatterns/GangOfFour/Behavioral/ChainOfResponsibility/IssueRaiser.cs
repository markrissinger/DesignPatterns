using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.ChainOfResponsibility
{
    public class IssueRaiser
    {
        public IssueRaiser(IReceiver firstReceiver) 
        {
            FirstReceiver = firstReceiver;
        }

        public IReceiver FirstReceiver {  get; protected set; }

        public bool RaiseMessage(Message message)
        {
            if (FirstReceiver != null)
            {
                return FirstReceiver.HandleMessage(message);
            }
            return false;
        }
    }
}
