using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Adaptor
{
    public class Triangle : ITriangle
    {
        public double baseWidth { get; set; }
        public double height { get; set; }

        public double CalculateArea()
        {
            return baseWidth * height * 0.5;
        }
    }
}
