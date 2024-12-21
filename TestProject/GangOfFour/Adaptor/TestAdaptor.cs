using DesignPatterns.GangOfFour.Structural.Adaptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Adaptor
{
    public class TestAdaptor
    {
        [Fact]
        public void TestAdaptorStructure() 
        {
            double length = 5.0;
            double width = 10.0;

            Rectangle rectangle = new Rectangle() { length = length, width = width };
            Triangle triangle = new Triangle() { height = length, baseWidth = width };

            Calculator calculator = new Calculator();
            CalculatorAdaptor calculatorAdaptor = new CalculatorAdaptor();

            double rectangleArea = calculator.CalculateArea(rectangle);
            double triangleArea = calculatorAdaptor.CalculateArea(triangle);

            Assert.True(rectangleArea == triangleArea * 2.0);
        }

        [Fact]
        public void TestAdaptorStructureRevised()
        {
            double length = 5.0;
            double width = 10.0;

            Rectangle rectangle = new Rectangle() { length = length, width = width };
            double rectangleArea = rectangle.CalculateArea();

            Triangle triangle = new Triangle() { height = length, baseWidth = width };
            double triangleArea = triangle.CalculateArea();

            IRectangle adaptor = new TriangleAdaptor(triangle);
            var adaptorArea = adaptor.CalculateArea();

            Assert.True(adaptorArea == triangleArea);
        }
    }
}
