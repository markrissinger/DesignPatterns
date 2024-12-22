using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Structural.Facade
{
    public class RobotColor
    {
        private const string _defaultColor = "tan";
        public string Color { get; protected set; }

        public void SetColor(string color = _defaultColor) 
        {
            Color = color;
        }
    }
}
