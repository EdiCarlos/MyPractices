using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns
{
    class FacadePattern
    {
        class ProgramA
        {
            public void OperationA()
            {
                Console.WriteLine("Operation A");
            }
        }
        class ProgramB
        {
            public void OperationB()
            {
                Console.WriteLine("Operation B");
            }
        }
        class ProgramC
        {
            public void OperationC()
            {
                Console.WriteLine("Opeartion C");
            }
        }
        class Facade
        {
            ProgramA progA;
            ProgramB progB;
            ProgramC progC;
            public Facade()
            {
                progA = new ProgramA();
                progB = new ProgramB();
                progC = new ProgramC();
            }
            public void Operation1()
            {
                Console.WriteLine("Calling Operation 1");
                progA.OperationA();
                progB.OperationB();
            }
            public void Operation2()
            {
                Console.WriteLine("Calling Operation 2");
                progC.OperationC();
                progB.OperationB();
            }
        }
        public class UseOfFacade
        {
            public static void Facade()
            {
                FacadePattern.Facade facade = new Facade();
                facade.Operation1();
                facade.Operation2();
            }
        }
    }
}
