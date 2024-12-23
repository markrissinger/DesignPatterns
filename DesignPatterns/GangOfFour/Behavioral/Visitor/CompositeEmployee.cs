using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public class CompositeEmployee : IEmployee
    {
        public CompositeEmployee(string name, string department, int yearsOfExperience)
        {
            _name = name;
            _department = department;
            _yearsOfExperience = yearsOfExperience;
            _employees = new List<IEmployee>();
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

        private List<IEmployee> _employees;
        public List<IEmployee> Employees
        {
            get
            {
                return _employees;
            }
            protected set
            {
                _employees = value;
            }
        }
        public void Add(IEmployee employee)
        {
            _employees.Add(employee);
        }
        public void Remove(IEmployee employee)
        {
            _employees.Remove(employee);
        }

        public int GetNumberOfDirectReports()
        {
            return _employees.Count;
        }

        public int GetNumberOfEmployees()
        {
            int count = 0;
            foreach (var employee in _employees)
            {
                count++;

                if (employee is CompositeEmployee)
                {
                    count += ((CompositeEmployee)employee).GetNumberOfEmployees();
                }
            }
            return count;
        }

        public string PrintStructure()
        {
            StringBuilder structure = new StringBuilder();
            structure.Append("Name: " + _name + " - Department: " + _department + Environment.NewLine + " - YOE: " + _yearsOfExperience);

            foreach (var employee in _employees)
            {
                structure.Append(employee.PrintStructure());
            }

            return structure.ToString();
        }

        public bool EligibleForPromotion { get; protected set; } = false;
        public bool Accept(IVisitor visitor)
        {
            EligibleForPromotion = visitor.VisitCompositeElement(this);
            return EligibleForPromotion;
        }
    }
}
