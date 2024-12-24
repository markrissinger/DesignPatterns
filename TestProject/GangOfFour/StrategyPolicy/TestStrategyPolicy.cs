using DesignPatterns.GangOfFour.Behavioral.StrategyPolicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.StrategyPolicy
{
    /// <summary>
    /// Makes classes independent from the algorithms. Classes delegate 
    /// the algorithms to the Strategy object at runtime.
    /// </summary>
    public class TestStrategyPolicy
    {
        [Fact]
        public void TestStrategyPolicyBehavior()
        {
            // Initialize
            Context context = new();

            // Test ChoiceOne
            IChoice? choice = new ChoiceOne();
            context.Choice = choice;
            Assert.True(context.Choice is ChoiceOne);

            // Test ChoiceTwo
            choice = new ChoiceTwo();
            context.Choice = choice;
            Assert.True(context.Choice is ChoiceTwo);
        }
    }
}
