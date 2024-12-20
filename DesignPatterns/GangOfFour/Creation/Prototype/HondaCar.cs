using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.Prototype
{
    public class HondaCar : BaseCar
    {
        public HondaCar(string modelName)
        {
            ModelName = modelName;
        }

        public override BaseCar Clone()
        {
            return (HondaCar)MemberwiseClone();
        }
    }
}
