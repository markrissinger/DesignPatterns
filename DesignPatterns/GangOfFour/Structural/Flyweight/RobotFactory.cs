using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Flyweight
{
    public class RobotFactory
    {
        private static Dictionary<FlyweightConstants.RobotType, IRobot> _existingRobots = new();

        public IRobot GetRobot(FlyweightConstants.RobotType robotType)
        {
            IRobot requestedRobot = null;

            if (_existingRobots.ContainsKey(robotType))
            {
                requestedRobot = _existingRobots[robotType];
            }
            else
            {
                switch (robotType)
                {
                    case FlyweightConstants.RobotType.Small:
                        requestedRobot = new Robot(FlyweightConstants.RobotType.Small);
                        _existingRobots.Add(requestedRobot.RobotType, requestedRobot);
                        break;
                    case FlyweightConstants.RobotType.Large:
                        requestedRobot = new Robot(FlyweightConstants.RobotType.Large);
                        _existingRobots.Add(requestedRobot.RobotType, requestedRobot);
                        break;
                    default:
                        throw new Exception("Invalid Robot Type.");
                }
            }
            return requestedRobot;
        }

        // Count to help keep track of number of objects
        public int TotalObjectsCreated
        {
            get { return _existingRobots.Count; }
        }
    }
}
