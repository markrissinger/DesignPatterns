using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Mediator
{
    public abstract class AbstractColleague
    {
        public AbstractColleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected IMediator _mediator;
        public IMediator Mediator { get { return _mediator; } }

        public string Name { get; set; }
    }
}
