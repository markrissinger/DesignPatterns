using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Facade
{
    public class RobotBody
    {
        public bool HandsExist { get; protected set; }
        public void CreateHands()
        {
            HandsExist = true;
        }
        public void DestroyHands() 
        { 
            HandsExist = false;
        }

        public bool RemainingPartsExist { get; protected set; }
        public void CreateRemainingParts()
        {
            RemainingPartsExist = true;
        }
        public void DestroyRemainingParts()
        {
            RemainingPartsExist = false;
        }
    }
}
