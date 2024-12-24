using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Interpreter
{
    public abstract class AbstractInputExpression
    {
        public abstract void Interpret(Context context);
    }
}
