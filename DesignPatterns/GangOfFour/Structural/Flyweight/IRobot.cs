using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Flyweight
{
    public interface IRobot
    {
        FlyweightConstants.RobotType RobotType { get; set; }
        void Print();
    }
}
