using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Decorator
{
    public class ConcreteDecoratorEx2 : AbstractDecorator
    {
        public ConcreteDecoratorEx2(Component c) : base(c)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorEx2({base.Operation()})";
        }
    }
}
