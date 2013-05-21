using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StartergyPatternSample
{
    class StratergyPatternSample
    {
        public class Context
        {
            public const int Start = 5;
            public int Counter = 10;
            private IStratergy stratergy = new Stratergy1();

            public int Algorithm()
            {
                return stratergy.Move(this);
            }

            public void SwitchStratergy()
            {
                if (stratergy is Stratergy1)
                {
                    stratergy = new Stratergy2();
                }
                else
                {
                    stratergy = new Stratergy2();
                }
            }
        }

        public interface IStratergy
        {
            int Move(Context cn);
        }

        public class Stratergy1 : IStratergy
        {
            #region IStratergy Members

            public int Move(Context cn)
            {
                return ++cn.Counter;
            }

            #endregion
        }

        public class Stratergy2 : IStratergy
        {

            #region IStratergy Members

            public int Move(Context cn)
            {
                return --cn.Counter;
            }

            #endregion
        }

        public class Client
        {
            public static void Run()
            {
                Context context = new Context();
                Random r = new Random();
                for (int i = 0; i < Context.Start + 15; i++)
                {
                    if (r.Next(3) == 2)
                    {
                        Console.Write("||");
                        context.SwitchStratergy();
                    }
                    
                    Console.Write(context.Algorithm());
                }
                Console.WriteLine();
            }
        }
    }


}
