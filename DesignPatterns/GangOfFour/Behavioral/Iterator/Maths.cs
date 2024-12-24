using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Iterator
{
    public class Maths : ISubjects
    {
        public Maths()
        {
            _subjects = new List<string>() 
            { 
                "Calculus", 
                "Discrete Math", 
                "Linear Algebra", 
                "Partial Differential Equations" 
            };
        }

        private List<string> _subjects;
        public List<string> Subjects
        {
            get { return _subjects; }
            set { _subjects = value; }
        }

        public IIterator CreateIterator()
        {
            return new MathsIterator(_subjects);
        }
    }
}
