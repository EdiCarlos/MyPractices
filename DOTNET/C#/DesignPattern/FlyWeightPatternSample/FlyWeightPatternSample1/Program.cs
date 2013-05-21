using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeightPatternSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();
            ((Flyweight)factory["X"]).Operation(1);
            ((Flyweight)factory["Y"]).Operation(1);
            ((Flyweight)factory["Z"]).Operation(1);
            ((Flyweight)factory["X"]).Operation(1);
            ConcreteFlyWeight concrete = new ConcreteFlyWeight();
            concrete.Operation(2);
            UnsharedFlyWeight unshareFlyWeight = new UnsharedFlyWeight();
            unshareFlyWeight.Operation(2);
        }
    }
}
