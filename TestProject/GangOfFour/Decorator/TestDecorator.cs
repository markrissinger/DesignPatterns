using DesignPatterns.GangOfFour.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Decorator
{
    public class TestDecorator
    {
        [Fact]
        public void TestDecoratorStructure()
        {
            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecoratorEx1 decorator1 = new(component);
            ConcreteDecoratorEx2 decorator2 = new(decorator1);

            var x = decorator2.Operation();
            Assert.True(x == "ConcreteDecoratorEx2(ConcreteDecoratorEx1(ConcreteComponent))");
        }
    }
}
