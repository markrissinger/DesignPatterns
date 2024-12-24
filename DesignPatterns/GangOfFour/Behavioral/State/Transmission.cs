using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.State
{
    public class Transmission
    {
        public Transmission()
        {
            _currentGear = new StatePark(this);
        }
        
        private IState _currentGear;
        public IState CurrentGear
        {
            get { return _currentGear; }
            set { _currentGear = value; }
        }

        public void ShiftToDrive()
        {
            _currentGear.ShiftToDrive();
        }

        public void ShiftToOverdrive()
        {
            _currentGear.ShiftToOverdrive();
        }

        public void ShiftToReverse()
        {
            _currentGear.ShiftToReverse();
        }

        public void ShiftToPark()
        {
            _currentGear.ShiftToPark();
        }
    }
}
