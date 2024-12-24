using DesignPatterns.GangOfFour.Behavioral.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Command
{
    public class TestCommand
    {
        [Fact]
        public void TestCommandBehavior()
        {
            // Initialize
            IReceiver receiver = new Receiver1();
            ICommand currentCommand = new DesignPatterns.GangOfFour.Behavioral.Command.Command(receiver);
            Invoke invoker = new();
            invoker.SetCommand(currentCommand);

            invoker.ExecuteCommand();
            invoker.ExecuteCommand();
            Assert.True(((Receiver1)receiver).Number == 12);

            invoker.UndoCommand();
            invoker.UndoCommand();
            Assert.True(((Receiver1)receiver).Number == 10);
        }
    }
}
