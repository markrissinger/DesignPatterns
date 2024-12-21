using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Adaptor
{
    public class Calculator
    {
        public double CalculateArea(Rectangle rectangle)
        {
            return rectangle.width * rectangle.length;
        }
    }
}
