using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.State
{
    public class StateDrive : IState
    {
        public StateDrive(Transmission transmission)
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
            // Do nothing - already in drive
        }

        public void ShiftToOverdrive()
        {
            _transmission.CurrentGear = new StateOverdrive(_transmission);
        }

        public void ShiftToPark()
        {
            _transmission.CurrentGear = new StatePark(_transmission);
        }

        public void ShiftToReverse()
        {
            _transmission.CurrentGear = new StateReverse(_transmission);
        }
    }
}
