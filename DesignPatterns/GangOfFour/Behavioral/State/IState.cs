using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.State
{
    public interface IState
    {
        void ShiftToDrive();
        void ShiftToOverdrive();
        void ShiftToReverse();
        void ShiftToPark();
    }
}
