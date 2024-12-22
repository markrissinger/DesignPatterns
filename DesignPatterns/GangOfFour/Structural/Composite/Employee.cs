using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Composite
{
    public class Employee : IEmployee
    {
        public Employee(string name, string department)
        {
            _name = name;
            _department = department;
        }

        private string _name;
        private string _department;

        public string PrintStructures()
        {
            return "Name: " + _name + " - Department: " + _department + Environment.NewLine;
        }
    }
}
