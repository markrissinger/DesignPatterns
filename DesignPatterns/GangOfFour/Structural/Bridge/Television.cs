using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Bridge
{
    public class Television : ElectronicGoods
    {
        public override string MoveToCurrentState()
        {
            return State.MoveState();
        }

        public Television(IState state) 
        {
            State = state;
        }
    }
}
