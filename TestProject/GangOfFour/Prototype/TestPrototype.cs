using DesignPatterns.GangOfFour.Creation.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Prototype
{
    public class TestPrototype
    {
        [Fact]
        public void TestPrototypeCreation()
        {
            BaseCar hondaBase = new HondaCar("Honda");
            BaseCar honda1 = hondaBase.Clone();
            BaseCar honda2 = hondaBase.Clone();

            // Ensure the two are separate instances
            Assert.NotEqual(honda1, honda2);
        }
    }
}
