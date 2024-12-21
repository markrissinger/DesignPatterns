using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Decorator
{
    public abstract class AbstractDecorator : Component
    {
        public AbstractDecorator(Component c) 
        {
            SetComponent(c);
        }

        public Component? Component { get; private set; }

        public void SetComponent(Component c)
        {
            Component = c;
        }

        public override string Operation()
        {
            return (this.Component != null) ? this.Component.Operation() : string.Empty;
        }
    }
}
