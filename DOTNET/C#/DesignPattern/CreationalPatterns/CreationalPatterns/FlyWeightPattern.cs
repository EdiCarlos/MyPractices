using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CreationalPatterns
{
    class FlyWeightPattern
    {
        interface IFlyWeight
        {
            void Operation(int exterinsicState);
        }
        class ConcreteFlyWeight : IFlyWeight
        {
            public void Operation(int exterinsicState)
            {
                Console.WriteLine("Concrete FlyWeight : " + exterinsicState);
            }
        }
        class UnSharedConcreteFlyweight : IFlyWeight
        {
            public void Operation(int exterinsicState)
            {
                Console.WriteLine("Unshared Concrete FlyWeight : " + exterinsicState);
            }
        }
        class FlyWeightFactory 
        {
            Hashtable table;
            public void SetFlyWeight(ConcreteFlyWeight flyWeight, string key)
            {
                if (table == null)
                {
                    table = new Hashtable();
                }
                table.Add(key, flyWeight);
            }
            public ConcreteFlyWeight GetConFlyWeight(string  key)
            {
                if (table == null)
                {
                    throw new NullReferenceException("_listConcreteFlyWeight has not been initialized");
                }
                return ((ConcreteFlyWeight)table[key]);
            }
        }
        public class UseFlyWeight
        {
            public static void FlyWeight()
            {
                int exterinsicSate = 22;
                FlyWeightFactory factory = new FlyWeightFactory();
                factory.SetFlyWeight(new ConcreteFlyWeight(), "X");
                factory.SetFlyWeight(new ConcreteFlyWeight(), "Y");
                factory.SetFlyWeight(new ConcreteFlyWeight(), "Z");

                factory.GetConFlyWeight("X").Operation(--exterinsicSate);
                factory.GetConFlyWeight("Y").Operation(--exterinsicSate);
                factory.GetConFlyWeight("Z").Operation(--exterinsicSate);

                UnSharedConcreteFlyweight un = new UnSharedConcreteFlyweight();
                un.Operation(--exterinsicSate);

            }
        }
    }
}
