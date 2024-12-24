using DesignPatterns.GangOfFour.Behavioral.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Interpreter
{
    public class TestInterpreter
    {
        [Fact]
        public void TestInterpreterBehavior()
        {
            // Initialize
            string inputString = "123";
            Context context = new(inputString);
            List<AbstractInputExpression> expressionTree = new() { new HundredsExpression(), new TensExpression(), new UnitExpression() };

            // Evaluate input
            foreach(AbstractInputExpression expression in expressionTree)
            {
                expression.Interpret(context);
            }

            Assert.True(!string.IsNullOrEmpty(context.OutputString));
        }
    }
}
