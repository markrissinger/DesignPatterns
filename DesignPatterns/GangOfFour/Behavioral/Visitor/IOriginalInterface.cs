using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public interface IOriginalInterface
    {
        public void Accept(IVisitor visitor);
    }
}
