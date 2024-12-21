using DesignPatterns.GangOfFour.Creation.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Builder
{
    public class TestBuilder
    {
        [Fact]
        public void TestBuilderCreation()
        {
            Director director = new Director();

            var carBrand = "Honda";
            var truckBrand = "Ford";
            var motorcycleBrand = "Kawasaki";

            IBuilder carBuilder = new Car(carBrand);
            IBuilder truckBuilder = new Truck(truckBrand);
            IBuilder motorcycleBuilder = new Motorcycle(motorcycleBrand);

            // Make Car
            director.Construct(carBuilder);
            Product product1 = carBuilder.GetVehicle();


            // Make Truck
            director.Construct(truckBuilder);
            Product product2 = truckBuilder.GetVehicle();

            // Make Motorcycle
            director.Construct(motorcycleBuilder);
            Product product3 = motorcycleBuilder.GetVehicle();

            Assert.Contains(product1.ShowParts, x => x.Contains(carBrand));
            Assert.Contains(product2.ShowParts, x => x.Contains(truckBrand));
            Assert.Contains(product3.ShowParts, x => x.Contains(motorcycleBrand));
        }
    }
}
