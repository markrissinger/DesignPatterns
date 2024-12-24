using DesignPatterns.GangOfFour.Behavioral.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Template
{
    /// <summary>
    /// Define the structure of an algorithm and then defer some
    /// of that responsibility to the subclass(es). Useful if you 
    /// need a multistep algorithm and want to allow subclasses to 
    /// customize it.
    /// </summary>
    public class TestTemplate
    {
        [Fact]
        public void TestTemplateBehavior()
        {
            BaseEngineering baseEngineering = new SoftwareEngineering();
            baseEngineering.Assignments();
            Assert.False(baseEngineering.IncludeCapstoneProject());

            baseEngineering = new ElectricalEngineering();
            baseEngineering.Assignments();
            Assert.True(baseEngineering.IncludeCapstoneProject());
        }
    }
}
