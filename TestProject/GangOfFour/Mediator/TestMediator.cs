using DesignPatterns.GangOfFour.Behavioral.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Mediator
{
    /// <summary>
    /// Focuses on controlling and coordinating interactions of a group of 
    /// objects that cannot refer to each other explicitly. Helps reduce the 
    /// number of interconnections between objects, which promotes loose coupling.
    /// 
    /// Mediator vs. Facade: Similar structure, but different intent. Mediators act 
    /// as an interface among multiple objects to do a smooth transition while Facade 
    /// acts as an interface of a single object.
    /// </summary>
    public class TestMediator
    {
        [Fact]
        public void TestMediatorBehavior()
        {
            // Initialize
            DesignPatterns.GangOfFour.Behavioral.Mediator.Mediator mediator = new();
            Colleague1 colleague1 = new(mediator, "Tom");
            Colleague2 colleague2 = new(mediator, "Tim");
            ColleagueBoss colleagueBoss = new(mediator, "Todd");
            ColleagueUnknown colleagueUnknown = new(mediator, "Tory");

            // Register
            mediator.Register(colleague1);
            mediator.Register(colleague2);
            mediator.Register(colleagueBoss);

            // Test Registered
            string output = colleague1.Send("Test Message");
            Assert.True(!string.IsNullOrEmpty(output));

            // Test Unregistered
            output = colleagueUnknown.Send("Test Message");
            Assert.True(string.IsNullOrEmpty(output));
        }
    }
}
