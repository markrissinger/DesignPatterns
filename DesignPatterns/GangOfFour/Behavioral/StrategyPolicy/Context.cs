using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.StrategyPolicy
{
    public class Context
    {
        private IChoice _choice;
        public IChoice Choice
        {
            get { return _choice; }
            set { _choice = value; }
        }
    }
}
