using DesignPatterns.GangOfFour.Structural.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Composite
{
    public class TestComposite
    {
        [Fact]
        public void TestCompositeStructure()
        {
            CompositeEmployee principal = InitializeStructure();

            string structure = principal.PrintStructures();
            int numberOfDirectReports = principal.GetNumberOfDirectReports();
            int numberOfEmployees = principal.GetNumberOfEmployees();

            Assert.True(numberOfDirectReports == 2);
            Assert.True(numberOfEmployees == 7);
        }

        private CompositeEmployee InitializeStructure()
        {
            const string mathDepartment = "Math";
            const string cseDepartment = "Computer Science";

            // Create employees
            CompositeEmployee principal = new CompositeEmployee("Tom (Principal)", "Planning-Supervising-Managing");

            CompositeEmployee hodMath = new CompositeEmployee("Daniel (HOD-Math)", mathDepartment);
            CompositeEmployee hodCse = new CompositeEmployee("Todd (HOD-CSE)", cseDepartment);

            Employee mathTeacher1 = new Employee("Math Teacher 1", mathDepartment);
            Employee mathTeacher2 = new Employee("Math Teacher 2", mathDepartment);

            Employee cseTeacher1 = new Employee("CSE Teacher 1", cseDepartment);
            Employee cseTeacher2 = new Employee("CSE Teacher 2", cseDepartment);
            Employee cseTeacher3 = new Employee("CSE Teacher 3", cseDepartment);

            // Create structure
            hodMath.AddEmployee(mathTeacher1);
            hodMath.AddEmployee(mathTeacher2);

            hodCse.AddEmployee(cseTeacher1);
            hodCse.AddEmployee(cseTeacher2);
            hodCse.AddEmployee(cseTeacher3);

            principal.AddEmployee(hodMath);
            principal.AddEmployee(hodCse);

            return principal;
        }
    }
}
