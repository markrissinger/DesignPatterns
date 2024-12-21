using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Adaptor
{
    public class CalculatorAdaptor
    {
        public double CalculateArea(Triangle triangle)
        {
            Calculator calculator = new();
            Rectangle rectangle = new Rectangle();

            rectangle.width = triangle.baseWidth;
            rectangle.length = triangle.height;

            return calculator.CalculateArea(rectangle) * 0.5;
        }
    }
}
