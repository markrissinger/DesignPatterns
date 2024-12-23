using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public interface IEmployee
    {
        string PrintStructure();
        bool Accept(IVisitor visitor);
    }
}
