using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Flyweight
{
    public class Robot : IRobot
    {
        public Robot(FlyweightConstants.RobotType robotType) 
        {
            RobotType = robotType;
        }

        public FlyweightConstants.RobotType RobotType { get; set; }

        public void Print()
        {
            // Do something
        }
    }
}
