using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Command
{
    public class Invoke
    {
        private ICommand _command;
        public ICommand Command
        {
            get { return _command; }
            set { _command = value; }
        }

        public void SetCommand(ICommand command)
        {
            this._command = command;
        }
        public void ExecuteCommand()
        {
            _command.Do();
        }
        public void UndoCommand()
        {
            _command.UnDo();
        }
    }
}
