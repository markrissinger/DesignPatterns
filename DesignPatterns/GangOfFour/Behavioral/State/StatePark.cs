using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.State
{
    public class StatePark : IState
    {
        public StatePark(Transmission transmission)
        {
            _transmission = transmission;
        }

        private Transmission _transmission;
        Transmission Transmission
        {
            get
            {
                return _transmission;
            }
            set
            {
                _transmission = value;
            }
        }

        public void ShiftToDrive()
        {
            _transmission.CurrentGear = new StatePark(_transmission);
        }

        public void ShiftToOverdrive()
        {
            // Do nothing - park does not support overdrive
        }

        public void ShiftToPark()
        {
            // Do nothing - already in park
        }

        public void ShiftToReverse()
        {
            _transmission.CurrentGear = new StateReverse(_transmission);
        }
    }
}
