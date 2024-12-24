using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Interpreter
{
    public class UnitExpression : AbstractInputExpression
    {
        public override void Interpret(Context context)
        {
            if (context.ValidInput)
            {
                int units = (context.InputInteger % 100) % 10;
                switch (units)
                {
                    case 1:
                        context.OutputString += "One";
                        break;
                    case 2:
                        context.OutputString += "Two";
                        break;
                    case 3:
                        context.OutputString += "Three";
                        break;
                    case 4:
                        context.OutputString += "Four";
                        break;
                    case 5:
                        context.OutputString += "Five";
                        break;
                    case 6:
                        context.OutputString += "Six";
                        break;
                    case 7:
                        context.OutputString += "Seven";
                        break;
                    case 8:
                        context.OutputString += "Eight";
                        break;
                    case 9:
                        context.OutputString += "Nine";
                        break;
                    default:
                        context.OutputString += "";
                        break;
                }
            }
        }
    }
}
