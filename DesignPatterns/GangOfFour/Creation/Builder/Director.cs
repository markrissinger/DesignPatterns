using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.Builder
{
    public class Director
    {
        IBuilder builder;

        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.Start();
            builder.BuildBody();
            builder.AddWheels();
            builder.AddLights();
            builder.End();
        }
    }
}
