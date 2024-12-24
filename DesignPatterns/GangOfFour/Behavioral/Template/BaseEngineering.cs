using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Template
{
    public abstract class BaseEngineering
    {
        public void Assignments()
        {
            Math();
            TechnicalSkills();
            SpecialProjects();
            if (IncludeCapstoneProject())
            {
                CapstoneProject();
            }
        }
        private void Math()
        {

        }
        private void TechnicalSkills()
        {

        }
        private void CapstoneProject()
        {

        }
        public abstract void SpecialProjects();
        public virtual bool IncludeCapstoneProject() { return false; }
    }
}
