using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.Singleton
{
    /// <summary>
    /// Example of how to setup/use a Singleton class
    /// </summary>
    public sealed class Singleton
    {
        // Private static field to create the instance
        private static readonly Singleton _instance = new();

        // Private constructor to prevent multiple instances from being created
        private Singleton() { }

        // Public property to allow the single instance to be used
        public static Singleton Instance { get { return _instance; } }
    }
}
