using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Bridge
{
    public class VCD : ElectronicGoods
    {
        public override string MoveToCurrentState()
        {
            return State.MoveState();
        }

        public VCD(IState state)
        {
            State = state;
        }
    }
}
