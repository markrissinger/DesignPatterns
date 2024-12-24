using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Mediator
{
    public class Mediator : IMediator
    {
        private List<AbstractColleague> _participants = new List<AbstractColleague>();
        public List<AbstractColleague> Participants { get { return _participants; } }

        public void Register(AbstractColleague colleague)
        {
            _participants.Add(colleague);
        }

        public void Unregister(AbstractColleague colleague)
        {
            _participants.Remove(colleague);
        }

        public string Send(AbstractColleague colleague, string message)
        {
            if (_participants.Contains(colleague))
            {
                return string.Format("[{0}] Posts: {1} - Last Message Posted: {2}", colleague.Name, message, DateTime.Now);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
