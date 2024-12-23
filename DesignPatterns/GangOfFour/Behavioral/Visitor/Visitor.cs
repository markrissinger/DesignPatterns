﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public class Visitor : IVisitor
    {
        public void Visit(OriginalClass originalClass)
        {
            originalClass.Tracker = 100;
        }
    }
}
