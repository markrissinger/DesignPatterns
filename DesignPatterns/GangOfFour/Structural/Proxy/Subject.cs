using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleToAttribute("TestProject")]
namespace DesignPatterns.GangOfFour.Structural.Proxy
{
    internal abstract class Subject
    {
        public abstract void DoSomeWork();
    }
}
