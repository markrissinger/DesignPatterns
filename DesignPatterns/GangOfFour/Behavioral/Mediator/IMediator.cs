using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Mediator
{
    public interface IMediator
    {
        string Send(AbstractColleague fromColleague, string message);
    }
}
