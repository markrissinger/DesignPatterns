using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Bridge
{
    public abstract class ElectronicGoods
    {
        public IState State { get; set; } = new OffState();

        public abstract string MoveToCurrentState();
    }
}
