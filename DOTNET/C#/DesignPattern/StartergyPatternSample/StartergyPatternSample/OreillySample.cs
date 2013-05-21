using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StartergyPatternSample
{
    public class Sample1
    {
        public interface IState
        {
            int ChangeState(Context context);
        }
        public class Strategy1 : IState
        {
            public int ChangeState(Context cn)
            {
                return ++cn.counter;
            }
        }
        public class Strategy2 : IState
        {
            public int ChangeState(Context cn)
            {
                return --cn.counter;
            }
        }
        public class Context
        {
            public const int limit = 10;
            public int counter = 5;
            IState state = new Strategy1();
            public int Algorithym()
            {
                return state.ChangeState(this);
            }
            public void SwitchStratergy()
            {
                if (state is Strategy1)
                {
                    state = new Strategy2();
                }
                else
                {
                    state = new Strategy1();
                }
            }
        }
        public class Client
        {
            public static void RunMain()
            {
                Context con = new Context();
                Random rn = new Random();
                for (int i = 0; i < 25; i++)
                {
                    int rResult = rn.Next(3);
                    if (rResult == 2)
                    {
                        con.SwitchStratergy();
                        Console.Write("||");
                    }
                    Console.Write(con.Algorithym());
                }
                Console.WriteLine();
            }
        }
    }
}
