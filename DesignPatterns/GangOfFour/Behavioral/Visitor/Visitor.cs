using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public class Visitor : IVisitor
    {
        public bool VisitCompositeElement(CompositeEmployee employee)
        {
            return employee.YearsOfExperience > 15;
        }

        public bool VisitLeafElement(Employee employee)
        {
            return employee.YearsOfExperience > 12;
        }
    }
}
