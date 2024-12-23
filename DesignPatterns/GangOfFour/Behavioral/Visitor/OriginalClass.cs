using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public class OriginalClass : IOriginalInterface
    {
        public IVisitor Visitor { get; protected set; }

        private int tracker = 5;
        public int Tracker
        {
            get
            {
                return tracker;
            }
            set
            {
                tracker = value;
            }
        }

        public void Accept(IVisitor visitor)
        {
            Visitor = visitor;
            Visitor.Visit(this);
        }
    }
}
