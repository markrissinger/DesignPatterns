using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public class Employee : IEmployee
    {
        public Employee(string name, string department, int yearsOfExperience)
        {
            _name = name;
            _department = department;
            _yearsOfExperience = yearsOfExperience;
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            protected set
            {
                _name = value;
            }
        }

        private string _department;
        public string Department
        {
            get
            {
                return _department;
            }
            protected set
            {
                _department = value;
            }
        }

        private int _yearsOfExperience;
        public int YearsOfExperience
        {
            get
            {
                return _yearsOfExperience;
            }
            protected set
            {
                _yearsOfExperience = value;
            }
        }

        public string PrintStructure()
        {
            return "Name: " + _name + " - Department: " + _department + Environment.NewLine + " - YOE: " + _yearsOfExperience;
        }

        public bool EligibleForPromotion { get; protected set; } = false;
        public bool Accept(IVisitor visitor)
        {
            EligibleForPromotion = visitor.VisitLeafElement(this);
            return EligibleForPromotion;
        }
    }
}
