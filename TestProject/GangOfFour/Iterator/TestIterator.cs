using DesignPatterns.GangOfFour.Behavioral.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.Iterator
{
    public class TestIterator
    {
        [Fact]
        public void TestIteratorBehavior()
        {
            // Initialize
            ISubjects scienceSubjects = new Sciences();
            ISubjects mathsSubjects = new Maths();
            ISubjects artsSubjects = new Arts();

            IIterator scienceIterator = scienceSubjects.CreateIterator();
            IIterator mathsIterator = mathsSubjects.CreateIterator();
            IIterator artsIterator = artsSubjects.CreateIterator();

            List<string> totalSubjects = new List<string>();

            while (!scienceIterator.Complete())
            {
                totalSubjects.Add(scienceIterator.Next());
            }
            while (!mathsIterator.Complete())
            {
                totalSubjects.Add(mathsIterator.Next());
            }
            while (!artsIterator.Complete())
            {
                totalSubjects.Add(artsIterator.Next());
            }

            Assert.Equal(12, totalSubjects.Count);
        }
    }
}
