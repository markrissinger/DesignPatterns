using DesignPatterns.GangOfFour.Structural.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Facade
{
    public class TestFacade
    {
        [Fact]
        public void TestFacadeStructure()
        {
            RobotFacade robotFacade1 = new RobotFacade();
            robotFacade1.ConstructMilanoRobot();
            robotFacade1.DestroyMilanoRobot();

            RobotFacade robotFacade2 = new RobotFacade();
            robotFacade2.ConstructRobonautRobot();
            robotFacade2.DestroyRobonautRobot();

            Assert.Null(robotFacade1.RobotHands.CurrentRobotHands);
            Assert.False(robotFacade1.RobotBody.HandsExist);
            Assert.False(robotFacade1.RobotBody.RemainingPartsExist);

            Assert.Null(robotFacade2.RobotHands.CurrentRobotHands);
            Assert.False(robotFacade2.RobotBody.HandsExist);
            Assert.False(robotFacade2.RobotBody.RemainingPartsExist);
        }
    }
}