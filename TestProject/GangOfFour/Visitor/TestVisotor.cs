using DesignPatterns.GangOfFour.Behavioral.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Visitor
{
    public class TestVisotor
    {
        [Fact]
        public void TestVisitorBehavior()
        {
            // Get initial structure
            CompositeEmployee principal = InitializeStructure();

            IVisitor visitor = new DesignPatterns.GangOfFour.Behavioral.Visitor.Visitor();

            // Purposefully skip Principal - they can't be promoted
            int numberOfEmployeesEligibleForPromotion = 0;
            foreach(IEmployee emp in principal.Employees)
            {
                if (emp.Accept(visitor))
                    numberOfEmployeesEligibleForPromotion++;
                
                if (emp is CompositeEmployee)
                {
                    foreach(IEmployee emp2 in ((CompositeEmployee)emp).Employees)
                    {
                        if (emp2.Accept(visitor))
                            numberOfEmployeesEligibleForPromotion++;
                    }
                }
            }

            Assert.True(numberOfEmployeesEligibleForPromotion == 3);
        }

        private CompositeEmployee InitializeStructure()
        {
            const string mathDepartment = "Math";
            const string cseDepartment = "Computer Science";

            // Create employees
            CompositeEmployee principal = new CompositeEmployee("Tom (Principal)", "Planning-Supervising-Managing", 20);

            CompositeEmployee hodMath = new CompositeEmployee("Daniel (HOD-Math)", mathDepartment, 20);
            CompositeEmployee hodCse = new CompositeEmployee("Todd (HOD-CSE)", cseDepartment, 10);

            Employee mathTeacher1 = new Employee("Math Teacher 1", mathDepartment, 15);
            Employee mathTeacher2 = new Employee("Math Teacher 2", mathDepartment, 10);

            Employee cseTeacher1 = new Employee("CSE Teacher 1", cseDepartment, 15);
            Employee cseTeacher2 = new Employee("CSE Teacher 2", cseDepartment, 10);
            Employee cseTeacher3 = new Employee("CSE Teacher 3", cseDepartment, 5);

            // Create structure
            hodMath.Add(mathTeacher1);
            hodMath.Add(mathTeacher2);

            hodCse.Add(cseTeacher1);
            hodCse.Add(cseTeacher2);
            hodCse.Add(cseTeacher3);

            principal.Add(hodMath);
            principal.Add(hodCse);

            return principal;
        }
    }
}
