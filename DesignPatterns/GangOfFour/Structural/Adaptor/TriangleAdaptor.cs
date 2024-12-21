using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Adaptor
{
    internal class TriangleAdaptor : IRectangle
    {
        Triangle triangle;

        public TriangleAdaptor(Triangle triangle)
        {
            this.triangle = triangle;
        }   

        public double CalculateArea()
        {
            return triangle.CalculateArea();
        }
    }
}
