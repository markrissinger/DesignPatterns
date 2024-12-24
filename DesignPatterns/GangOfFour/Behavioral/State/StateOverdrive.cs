﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.State
{
    public class StateOverdrive : IState
    {
        public StateOverdrive(Transmission transmission)
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
            _transmission.CurrentGear = new StateDrive(_transmission);
        }

        public void ShiftToOverdrive()
        {
            // Do nothing - already in overdrive
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
