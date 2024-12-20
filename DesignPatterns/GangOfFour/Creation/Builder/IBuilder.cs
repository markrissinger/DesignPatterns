using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.Builder
{
    public interface IBuilder
    {
        void Start();
        void BuildBody();
        void AddWheels();
        void AddLights();
        void End();

        Product GetVehicle();
    }
}
