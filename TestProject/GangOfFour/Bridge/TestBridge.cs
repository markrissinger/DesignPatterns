using DesignPatterns.GangOfFour.Structural.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Bridge
{
    public class TestBridge
    {
        [Fact]
        public void TestBridgeStructure()
        {
            IState state = new OffState();

            // As Television
            ElectronicGoods electronicGoods = new Television(state);
            
            // Turn off
            electronicGoods.MoveToCurrentState();

            // Assert off
            Assert.True(electronicGoods.State is OffState);

            // Turn on
            electronicGoods.State = new OnState();
            electronicGoods.MoveToCurrentState();

            // Assert on
            Assert.True(electronicGoods.State is OnState);

            // As VCD
            electronicGoods = new VCD(state);

            // Turn off
            electronicGoods.State = new OffState();
            electronicGoods.MoveToCurrentState();

            // Assert off
            Assert.True(electronicGoods.State is OffState);

            // Turn on
            electronicGoods.State = new OnState();
            electronicGoods.MoveToCurrentState();

            // Assert on
            Assert.True(electronicGoods.State is OnState);
        }
    }
}
