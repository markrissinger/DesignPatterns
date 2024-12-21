using DesignPatterns.GangOfFour.Creation.AbstractFactory;

namespace TestProject.GangOfFour.AbstractFactory
{
    public class TestAbstractFactory
    {
        [Fact]
        public void TestAbstractFactoryInstances()
        {
            IVehicleFactory averageVehicleFactory = new AverageVehicleFactory();
            ICar averageCar1 = averageVehicleFactory.GetCar();
            ICar averageCar2 = averageVehicleFactory.GetCar();
            ITruck averageTruck1 = averageVehicleFactory.GetTruck();
            ITruck averageTruck2 = averageVehicleFactory.GetTruck();


            IVehicleFactory raceVehicleFactory = new RaceVehicleFactory();
            ICar raceCar1 = raceVehicleFactory.GetCar();
            ICar raceCar2 = raceVehicleFactory.GetCar();
            ITruck raceTruck1 = raceVehicleFactory.GetTruck();
            ITruck raceTruck2 = raceVehicleFactory.GetTruck();

            Assert.NotEqual(averageCar1, averageCar2);
            Assert.NotEqual(averageTruck1, averageTruck2);
            Assert.NotEqual(raceCar1, raceCar2);
            Assert.NotEqual(raceTruck1, raceTruck2);
        }
    }
}