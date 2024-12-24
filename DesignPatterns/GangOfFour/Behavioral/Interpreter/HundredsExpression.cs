using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Interpreter
{
    public class HundredsExpression : AbstractInputExpression
    {
        public override void Interpret(Context context)
        {
            if (context.ValidInput)
            {
                int hundreds = context.InputInteger / 100;
                switch (hundreds)
                {
                    case 1:
                        context.OutputString += "One Hundred";
                        break;
                    case 2:
                        context.OutputString += "Two Hundred";
                        break;
                    case 3:
                        context.OutputString += "Three Hundred";
                        break;
                    case 4:
                        context.OutputString += "Four Hundred";
                        break;
                    case 5:
                        context.OutputString += "Five Hundred";
                        break;
                    case 6:
                        context.OutputString += "Six Hundred";
                        break;
                    case 7:
                        context.OutputString += "Seven Hundred";
                        break;
                    case 8:
                        context.OutputString += "Eight Hundred";
                        break;
                    case 9:
                        context.OutputString += "Nine Hundred";
                        break;
                    default:
                        context.OutputString += "*";
                        break;
                }
            }
        }
    }
}
