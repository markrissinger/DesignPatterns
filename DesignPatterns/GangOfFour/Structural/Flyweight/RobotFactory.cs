using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Flyweight
{
    public class RobotFactory
    {
        Dictionary<FlyweightConstants.RobotType, IRobot> shapes = new();

        public int TotalObjectsCreated
        {
            get { return shapes.Count; }
        }

        public IRobot GetRobotFromFactory(FlyweightConstants.RobotType robotType)
        {
            IRobot respectiveRobot = null;

            if (shapes.ContainsKey(robotType))
            {
                respectiveRobot = shapes[robotType];
            }
            else
            {
                switch (robotType)
                {
                    case FlyweightConstants.RobotType.Small:
                        shapes.Add(FlyweightConstants.RobotType.Small, new Robot());
                        break;
                    case FlyweightConstants.RobotType.Large:
                        shapes.Add(FlyweightConstants.RobotType.Large, new LargeRobot());
                        break;
                    default:
                        throw new Exception("Invalid Robot Type.");
                }
            }
            return respectiveRobot;
        }
    }
}
