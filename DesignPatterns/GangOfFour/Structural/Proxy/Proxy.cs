using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleToAttribute("TestProject")]
namespace DesignPatterns.GangOfFour.Structural.Proxy
{
    internal class Proxy : Subject
    {
        public Subject cs;

        public override void DoSomeWork()
        {
            if (cs == null)
            {
                cs = new ConcreteSubject();
            }
            cs.DoSomeWork();
        }
    }
}
