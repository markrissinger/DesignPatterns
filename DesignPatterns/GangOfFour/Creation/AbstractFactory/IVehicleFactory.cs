using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.AbstractFactory
{
    internal interface IVehicleFactory
    {
        ICar GetCar();
        ITruck GetTruck();
    }
}
