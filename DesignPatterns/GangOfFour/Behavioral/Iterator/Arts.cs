using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Iterator
{
    public class Arts : ISubjects
    {
        public Arts()
        {
            _subjects = new string[] 
            { 
                "3D Art", 
                "Choir", 
                "English", 
                "Theater" 
            };
        }

        private string[] _subjects;
        public string[] Subjects
        {
            get { return _subjects; }
            set { _subjects = value; }
        }

        public IIterator CreateIterator()
        {
            return new ArtsIterator(_subjects);
        }
    }
}
