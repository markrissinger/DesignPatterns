﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.GangOfFour.Behavioral.Mediator
{
    public class Colleague2 : AbstractColleague
    {
        public Colleague2(IMediator mediator, string name) : base(mediator)
        {
            Name = name;
        }

        public string Send(string message)
        {
            return Mediator.Send(this, message);
        }
    }
}