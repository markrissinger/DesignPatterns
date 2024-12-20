using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.AbstractFactory
{
    internal class RaceVehicleFactory : IVehicleFactory
    {
        public ICar GetCar()
        {
            return new RaceCar();
        }

        public ITruck GetTruck()
        {
            return new RaceTruck();
        }
    }
}
