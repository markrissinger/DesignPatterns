using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Proxy
{
    public class TestProxy
    {
        [Fact]
        public void TestProxyStructure()
        {
            DesignPatterns.GangOfFour.Structural.Proxy.Proxy proxy = new();
            proxy.DoSomeWork();

            Assert.NotNull(proxy.cs);
        }
    }
}
