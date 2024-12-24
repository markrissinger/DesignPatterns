using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Template
{
    public class ElectricalEngineering : BaseEngineering
    {
        public override void SpecialProjects()
        {
            // Do something
        }
        public override bool IncludeCapstoneProject()
        {
            return true;
        }
    }
}
