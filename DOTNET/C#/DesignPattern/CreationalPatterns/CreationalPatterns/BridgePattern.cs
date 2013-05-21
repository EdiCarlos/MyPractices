using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns
{
    class BridgePattern
    {
        interface IBridge
        {
            void Operation();
        }
        class ImplementationA : IBridge
        {
            public void Operation()
            {
                Console.WriteLine("Implementation A...");
            }
        }
        class ImplementationB : IBridge
        {
            public void Operation()
            {
                Console.WriteLine("Impelmenation B...");
            }
        }
        class BridgeImplementation
        {
            IBridge bridge;
            public BridgeImplementation(IBridge ibridge)
            {
                bridge = ibridge;
            }
            public void Operation()
            {
                bridge.Operation();
            }
        }
        internal class UseOfBridge
        {
            public static void Bridge()
            {
                new BridgeImplementation(new ImplementationA()).Operation();
                new BridgeImplementation(new ImplementationB()).Operation();
            }
        }
    }
}
