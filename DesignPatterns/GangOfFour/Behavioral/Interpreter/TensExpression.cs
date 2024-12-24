using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Interpreter
{
    public class TensExpression : AbstractInputExpression
    {
        public override void Interpret(Context context)
        {
            if (context.ValidInput)
            {
                int tens = (context.InputInteger % 100) / 10;
                switch (tens)
                {
                    case 1:
                        context.OutputString += "One Ten &";
                        break;
                    case 2:
                        context.OutputString += "Twenty";
                        break;
                    case 3:
                        context.OutputString += "Thirty";
                        break;
                    case 4:
                        context.OutputString += "Fourty";
                        break;
                    case 5:
                        context.OutputString += "Fifty";
                        break;
                    case 6:
                        context.OutputString += "Sixty";
                        break;
                    case 7:
                        context.OutputString += "Seventy";
                        break;
                    case 8:
                        context.OutputString += "Eighty";
                        break;
                    case 9:
                        context.OutputString += "Ninety";
                        break;
                    default:
                        context.OutputString += "";
                        break;
                }
            }
        }
    }
}
