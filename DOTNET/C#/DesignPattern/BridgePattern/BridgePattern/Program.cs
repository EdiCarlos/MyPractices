using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{

    public interface IBridge
    {
        void OperationImp();
    }
    public class ImplementationA : IBridge
    {
        public void OperationImp()
        {
            Console.WriteLine("Implementation A");
        }
    }
    public class ImplementationB : IBridge
    {
        public void OperationImp()
        {
            Console.WriteLine("Implementation B");
        }
    }
    public class Abstraction
    {
        IBridge bridge;
        public Abstraction(IBridge bridge)
        {
            this.bridge = bridge;
        }
        public void Operation()
        {
            bridge.OperationImp();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Abstraction implmentationA = new Abstraction(new ImplementationA());
            //Abstraction implmentationB = new Abstraction(new ImplementationB());
            //implmentationA.Operation();
            //implmentationB.Operation();
            Abstract implementationAA = new Abstract(new ImplementationAA());
            Abstract implementationAB = new Abstract(new ImplementationAB());
            implementationAA.OtherImplementation();
            implementationAB.OtherImplementation();
        }
    }
}
