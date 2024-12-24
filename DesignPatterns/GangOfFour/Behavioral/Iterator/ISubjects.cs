using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Iterator
{
    public interface ISubjects
    {
        public IIterator CreateIterator();
    }
}
