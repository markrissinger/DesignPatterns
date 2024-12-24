using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Iterator
{
    public class MathsIterator : IIterator
    {
        public MathsIterator(List<string> subjects)
        {
            _subjects = subjects;
        }
        private List<string> _subjects;
        private int _index;

        public bool Complete()
        {
            return _index >= _subjects.Count;
        }

        public string CurrentItem()
        {
            return _subjects[_index];
        }

        public void First()
        {
            _index = 0;
        }

        public string Next()
        {
            return _subjects[_index++];
        }
    }
}
