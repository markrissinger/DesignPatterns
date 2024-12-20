using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleToAttribute("TestProject")]
namespace DesignPatterns.GangOfFour.Creation.AbstractFactory
{
    internal class AverageCar : ICar
    {
        public void Drive()
        {
            // Do something
        }

        public void Stop()
        {
            // Do something
        }
    }
}
