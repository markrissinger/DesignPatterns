using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Adaptor
{
    public class Rectangle : IRectangle
    {
        public double length {  get; set; }
        public double width { get; set; }

        public double CalculateArea()
        {
            return length * width;
        }
    }
}
