using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Interpreter
{
    public class Context
    {
        public Context(string inputString)
        {
            ValidateInput(inputString);
            _inputString = inputString;
        }

        private int _inputInteger;
        public int InputInteger { get { return _inputInteger; } }

        private string _inputString;
        public string InputString { get { return _inputString; } }

        private string _outputString;
        public string OutputString
        {
            get { return _outputString; }
            set { _outputString = value; }
        }

        private bool _validInput;
        public bool ValidInput { get { return _validInput; } }

        public int ValidateInput(string inputString)
        {
            if (int.TryParse(inputString, out _inputInteger))
            {
                if (_inputInteger < 100 ||  _inputInteger > 999)
                {
                    throw new ArgumentException("input must be between 100 and 999");
                }
            }
            _validInput = true;
            return _inputInteger;
        }
    }
}
