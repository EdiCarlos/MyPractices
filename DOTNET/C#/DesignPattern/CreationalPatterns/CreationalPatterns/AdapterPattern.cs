using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns
{
    class AdapterPattern
    {
        interface IAdapter
        {
            double Sum(int num1, int num2);
        }
        class Adaptee
        {
            public double OldSum(double num1, double num2)
            {
                return num1 + num2;
            }
        }
        class Adapter : Adaptee, IAdapter
        {
            public double Sum(int num1, int num2)
            {
                double dNum1 = Convert.ToInt64(num1);
                double dNum2 = Convert.ToInt64(num2);
                return Math.Floor(base.OldSum(dNum1, dNum2));
            }
        }
        public class UseOfAdapter
        {
            public static void Adapter()
            {
                IAdapter adapter = new Adapter();
                Console.WriteLine(adapter.Sum(10, 2));
                Adaptee adaptee = new Adaptee();
                Console.WriteLine(adaptee.OldSum(10.00, 10.00));
            }
        }
    }

    class TwoAdapterPattern
    {
        interface IAircraft
        {
            int Height { get; }
            bool IsAirBrone { get;  }
            void TakeOff();
        }
        class AirCraft : IAircraft
        {
            bool isAirbrone;
            int height;
            public AirCraft()
            {
                isAirbrone = false;
                height = 0;
            }
            public int Height
            {
                get
                {
                    return height;
                }
            }

            public bool IsAirBrone
            {
                get
                {
                    return isAirbrone;
                }
            }

            public void TakeOff()
            {
                if (!isAirbrone)
                {
                    isAirbrone = true;
                    height = 100;
                }
            }
        }

        interface ISeaCraft
        {
            void IncreaseRev();
            int Speed { get; }
        }
        class SeaCraft : ISeaCraft
        {
            int speed = 0;
            public virtual void IncreaseRev()
            {
                speed += 10;
                Console.WriteLine("Seacraft engine speed increased to "+speed+" knots");
            }

            public int Speed
            {
                get { return speed; }
            }
        }

        class Seabird : SeaCraft, IAircraft
        {
            int height = 0;
            public int Height
            {
                get { return height; }
            }

            public bool IsAirBrone
            {
                get
                {
                    if (height > 50)
                        return true;
                    else
                        return false;
                }
            }

            public void TakeOff()
            {
                while (!IsAirBrone)
                {
                    IncreaseRev();
                }
            }
            public override void IncreaseRev()
            {
                base.IncreaseRev();
                if (Speed > 40)
                    height += 100;
            }
        }
        public class UseTwoWayAdapter
        {
            public static void TwoAdapter()
            {
                IAircraft aircraft = new AirCraft();
                aircraft.TakeOff();
                if (aircraft.IsAirBrone)
                {
                    Console.WriteLine("Aircraft engine is fine, fly at the height of "+aircraft.Height + " meters");
                }
                //ISeaCraft seaCraft = new SeaCraft();
                IAircraft seabird = new Seabird();
                seabird.TakeOff();
                ((ISeaCraft)seabird).IncreaseRev();
                ((ISeaCraft)seabird).IncreaseRev();
                ((ISeaCraft)seabird).IncreaseRev();

                if (seabird.IsAirBrone)
                {
                    Console.WriteLine("Seabird flying at height of " + seabird.Height + " meters and speed of " + ((ISeaCraft)seabird).Speed + " knots");

                }


            }
        }

    }
}
