using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Decorator
{
    public class ConcreteDecoratorEx1 : AbstractDecorator
    {
        public ConcreteDecoratorEx1(Component c) : base(c)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorEx1({base.Operation()})";
        }
    }
}
