using DesignPatterns.GangOfFour.Behavioral.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Observer
{
    public class TestObserver
    {
        [Fact]
        public void TestObserverBehavior()
        {
            // Initialize
            Observer1 observer1 = new Observer1("Obs1");
            Observer1 observer2 = new Observer1("Obs2");
            Observer2 observer3 = new Observer2("Obs3");

            Subject subject = new();

            // Register
            subject.Register(observer1);
            subject.Register(observer2);
            subject.Register(observer3);

            int newFlagValue = 5;
            subject.Flag = newFlagValue;

            Assert.True(observer1.Integer == newFlagValue);
            Assert.True(observer2.Integer == newFlagValue);
            Assert.True(observer3.Integer == newFlagValue);
        }
    }
}
