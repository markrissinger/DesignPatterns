using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.ChainOfResponsibility
{
    public class Message
    {
        public string Text { get; protected set; }
        public CoRConstants.MessagePriority Priority { get; protected set; }

        public Message(string message, CoRConstants.MessagePriority priority)
        {
            Text = message;
            Priority = priority;
        }
    }
}
