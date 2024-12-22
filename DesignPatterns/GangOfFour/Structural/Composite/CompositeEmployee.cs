using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Composite
{
    public class CompositeEmployee : IEmployee
    {
        public CompositeEmployee(string name, string department)
        {
            _name = name;
            _department = department;
            _employees = new();
        }

        private string _name;
        private string _department;
        private List<IEmployee> _employees;

        public void AddEmployee(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
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

        public string PrintStructures()
        {
            StringBuilder structure = new StringBuilder();
            structure.Append("Name: " + _name + " - Department: " + _department + Environment.NewLine);

            foreach (var employee in _employees)
            {
                structure.Append(employee.PrintStructures());
            }

            return structure.ToString();
        }
    }
}
