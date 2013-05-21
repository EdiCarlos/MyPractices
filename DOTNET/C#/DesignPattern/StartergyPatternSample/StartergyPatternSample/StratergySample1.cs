using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StartergyPatternSample
{
    class StratergySample1
    {
        interface IStratergy
        {
            int Algorithm(Context con);
        }

        class Context
        {
            public const int LIMIT = 5;
            public int Counter = 10;
            IStratergy stratergy = new Stratergy1();
            public int Algorithm()
            {
                return stratergy.Algorithm(this);
            }
            public void SwitchStratergy()
            {
                if (stratergy is Stratergy1)
                    stratergy = new Stratergy2();
                else
                    stratergy = new Stratergy2();
            }
        }
        class Stratergy1 : IStratergy
        {
            #region IStratergy Members

            public int Algorithm(Context con)
            {
                return ++con.Counter;
            }

            #endregion
        }
        class Stratergy2 : IStratergy
        {
            #region IStratergy Members

            public int Algorithm(Context con)
            {
                return --con.Counter;
            }

            #endregion
        }
        public class Client
        {
            public static void RunMain()
            {
                Context context = new Context();
                Random r = new Random();
                for (int i = 0; i < Context.LIMIT + 10; i++)
                {
                    if (r.Next(3) == 2)
                    {
                        context.SwitchStratergy();
                        Console.Write("||");
                    }
                    Console.Write(context.Algorithm() + ",");
                }
            }
        }
    }
}
