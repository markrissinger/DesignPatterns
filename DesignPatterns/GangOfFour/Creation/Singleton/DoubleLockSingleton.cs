using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.Singleton
{
    public sealed class DoubleLockSingleton
    {
        private static volatile DoubleLockSingleton instance;
        private static object locker = new object();
        private DoubleLockSingleton() { }

        public static DoubleLockSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        instance ??= new DoubleLockSingleton();
                    }
                }

                return instance;
            }
        }
    }
}
