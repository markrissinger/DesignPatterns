using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Facade
{
    public class RobotHands
    {
        public string? CurrentRobotHands { get; protected set; } = null;

        public void SetMilanoHands()
        {
            CurrentRobotHands = "Milano";
        }
        public void ResetMilanHands()
        {
            CurrentRobotHands = null;
        }

        public void SetRobonautHands()
        {
            CurrentRobotHands = "Robonaut";
        }
        public void ResetRobonautHands()
        {
            CurrentRobotHands = null;
        }
    }
}
