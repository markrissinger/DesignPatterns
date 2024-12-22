using DesignPatterns.GangOfFour.Structural.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Flyweight
{
    public class TestFlyweight
    {
        [Fact]
        public void TestFlyweightStructure()
        {
            RobotFactory robotFactory = new RobotFactory();
            Robot smallRobot = (Robot)robotFactory.GetRobot(FlyweightConstants.RobotType.Small);
            Robot largeRobot = (Robot)robotFactory.GetRobot(FlyweightConstants.RobotType.Large);

            // Loop over 10 times to grab small/large robot from factory; factory should have still created only one of each
            for (int i = 0; i < 10; i++)
            {
                smallRobot = (Robot)robotFactory.GetRobot(FlyweightConstants.RobotType.Small);
                largeRobot = (Robot)robotFactory.GetRobot(FlyweightConstants.RobotType.Large);
            }

            Assert.True(robotFactory.TotalObjectsCreated == 2);
            Assert.True(smallRobot.RobotType == FlyweightConstants.RobotType.Small);
            Assert.True(largeRobot.RobotType == FlyweightConstants.RobotType.Large);
        }
    }
}
