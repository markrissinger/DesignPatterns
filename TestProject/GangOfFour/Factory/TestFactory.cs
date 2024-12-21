using DesignPatterns.GangOfFour.Creation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Factory
{
    public class TestFactory
    {
        [Fact]
        public void TestBuilderCreation()
        {
            VehicleFactory carFactory = new CarFactory();
            IVehicle car1 = carFactory.CreateVehicle();
            IVehicle car2 = carFactory.CreateVehicle();

            VehicleFactory truckFactory = new TruckFactory();
            IVehicle truck1 = truckFactory.CreateVehicle();
            IVehicle truck2 = truckFactory.CreateVehicle();

            Assert.NotEqual(car1, car2);
            Assert.NotEqual(truck1, truck2);
        }
    }
}
