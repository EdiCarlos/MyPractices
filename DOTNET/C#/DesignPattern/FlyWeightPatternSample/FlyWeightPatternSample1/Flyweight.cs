using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FlyWeightPatternSample1
{
    public abstract class Flyweight
    {
        public abstract void Operation(int exterinsicState);
    }
    public class ConcreteFlyWeight : Flyweight
    {
        public override void Operation(int exterinsicState)
        {
            Console.WriteLine("Concrete Flyweight " + exterinsicState);
        }
    }
    public class UnsharedFlyWeight : Flyweight
    {
        public override void Operation(int exterinsicState)
        {
            Console.WriteLine("Unshared flyweight " + exterinsicState);
        }
    }
    public class FlyweightFactory
    {
        Hashtable table;// = new Hashtable();
        public FlyweightFactory()
        {
            table = new Hashtable();
            table.Add("X", new ConcreteFlyWeight());
            table.Add("Y", new ConcreteFlyWeight());
            table.Add("Z", new ConcreteFlyWeight());
        }
        public Flyweight this[object obj]
        {
            get
            {
                Flyweight retFlyWeight = null;
                if (table != null)
                {
                    retFlyWeight = (Flyweight)table[obj];
                }
                return retFlyWeight;
            }
        }
    }
}
