using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Iterator
{
    public class Sciences : ISubjects
    {
        public Sciences()
        {
            _subjects = new LinkedList<string>();
            _subjects.AddFirst("Biology");
            _subjects.AddFirst("Chemistry");
            _subjects.AddFirst("Computer Science");
            _subjects.AddFirst("Physics");
        }

        private LinkedList<string> _subjects;
        public LinkedList<string> Subjects
        {
            get { return _subjects; }
            set { _subjects = value; }
        }

        public IIterator CreateIterator()
        {
            return new SciencesIterator(_subjects);
        }
    }
}
