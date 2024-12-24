using DesignPatterns.GangOfFour.Behavioral.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Memento
{
    public class TestMemento
    {
        [Fact]
        public void TestMementoBehavior()
        {
            // Initialize - Originator's initial state should be "initialized"
            Originator oringalObject = new();
            DesignPatterns.GangOfFour.Behavioral.Memento.Memento memento = oringalObject.GetMemento();

            Assert.Equal("initialized", memento.State);
        }
    }
}
