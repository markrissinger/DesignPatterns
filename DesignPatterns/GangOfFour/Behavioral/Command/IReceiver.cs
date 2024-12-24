using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Behavioral.Command
{
    public interface IReceiver
    {
        void OptionalPreProcessing();
        void OptionalPostProcessing();

        int AddOne();
        int SubtractOne();
    }
}
