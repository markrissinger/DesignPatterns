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
            IVisitor visitor = new DesignPatterns.GangOfFour.Behavioral.Visitor.Visitor();
            OriginalClass originalClass = new();
            originalClass.Accept(visitor);

            Assert.True(originalClass.Tracker == 100);
        }
    }
}
