using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.Builder
{
    public class Product
    {
        private List<string> _parts;
        public Product()
        {
            _parts = new List<string>();
        }

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public List<string> ShowParts { get { return _parts; } }
    }
}
