using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Facade
{
    public class RobotFacade
    {
        public RobotColor RobotColor { get; internal set; }
        public RobotHands RobotHands { get; internal set; }
        public RobotBody RobotBody { get; internal set; }

        public RobotFacade()
        {
            RobotColor = new RobotColor();
            RobotHands = new RobotHands();
            RobotBody = new RobotBody();
        }

        public void ConstructMilanoRobot()
        {
            RobotColor.SetColor(); 
            RobotHands.SetMilanoHands();
            RobotBody.CreateHands();
            RobotBody.CreateRemainingParts();
        }
        public void DestroyMilanoRobot()
        {
            RobotHands.ResetMilanHands();
            RobotBody.DestroyHands();
            RobotBody.DestroyRemainingParts();
        }

        public void ConstructRobonautRobot()
        {
            RobotColor.SetColor("green");
            RobotHands.SetRobonautHands();
            RobotBody.CreateHands();
            RobotBody.CreateRemainingParts();
        }
        public void DestroyRobonautRobot()
        {
            RobotHands.ResetRobonautHands();
            RobotBody.DestroyHands();
            RobotBody.DestroyRemainingParts();
        }
    }
}
