using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplatePattern
{
    public class TourSample
    {
        public abstract class Trip
        {
            public void PerformTrip()
            {
                ComingTransport();
                Day1();
                Day2();
                Day3();
                ReturningTransport();
            }
            public abstract void ComingTransport();
            public abstract void Day1();
            public abstract void Day2();
            public abstract void Day3();
            public abstract void ReturningTransport();
        }

        class PackageA : Trip
        {
            public override void ComingTransport()
            {
                Console.WriteLine("Tourist coming by Air");
            }

            public override void Day1()
            {
                Console.WriteLine("Will be going to Cuirse!!!");
            }

            public override void Day2()
            {
                Console.WriteLine("Five Star Lunch in a five star hotel and site view of city in luxury bus");
            }

            public override void Day3()
            {
                Console.WriteLine("Will be going to Amusement Park");
            }

            public override void ReturningTransport()
            {
                Console.WriteLine("Retuning home by Air");
            }
        }
        class PackageB : Trip
        {
            public override void ComingTransport()
            {
                Console.WriteLine("Coming by train");
            }

            public override void Day1()
            {
                Console.WriteLine("Staying in 3 star hotel");
            }

            public override void Day2()
            {
                Console.WriteLine("Watch movie");
            }

            public override void Day3()
            {
                    Console.WriteLine("Do nothing");
            
            }

            public override void ReturningTransport()
            {
                Console.WriteLine("Go home by train");
            }
        }

        public class Client
        {
            public static void RunMain()
            {
                Trip t1 = new PackageA();
                t1.PerformTrip();
                t1 = new PackageB();
                t1.PerformTrip();
            }
        }
    }
}
