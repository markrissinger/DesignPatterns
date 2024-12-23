using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Bridge
{
    public class OffState : IState
    {
        public string MoveState()
        {
            return "Off";
        }
    }
}
