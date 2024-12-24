using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Mediator
{
    public class Colleague1 : AbstractColleague
    {
        public Colleague1(IMediator mediator, string name) : base(mediator)
        {
            Name = name;
        }

        public string Send(string message)
        {
            return Mediator.Send(this, message);
        }
    }
}
