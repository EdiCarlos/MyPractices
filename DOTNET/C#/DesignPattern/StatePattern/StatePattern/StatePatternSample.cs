using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class StatePatternSample
    {
        public interface IState
        {
            int MoveDown(Context context);
            int MoveUp(Context context);
        }

        class FastState : IState
        {
            public int MoveUp(Context context)
            {
                context.Counter += 2;
                return context.Counter;
            }

            public int MoveDown(Context context)
            {
                if (context.Counter < Context.LIMIT)
                {
                    context.State = new NormalState();
                    Console.Write("||");
                }
                context.Counter -= 5;
                return context.Counter;
            }
        }

        class NormalState : IState
        {

            #region IState Members

            public int MoveDown(Context context)
            {
                if (context.Counter < Context.LIMIT)
                {
                    context.State = new FastState();
                    Console.Write("||");
                }
                context.Counter -= 2;
                return context.Counter;
            }

            public int MoveUp(Context context)
            {
                context.Counter += 5;
                return context.Counter;
            }

            #endregion
        }

        public class Context
        {
            public const int LIMIT = 10;
            public int Counter = LIMIT;
            public IState State { get; set; }
            public int Request(int n)
            {
                if (n == 2)
                {
                    return State.MoveUp(this);
                }
                else
                {
                    return State.MoveDown(this);
                }
            }
        }

        public class Client
        {
            public static void RunMain()
            {
                Context context = new Context();
                context.State = new NormalState();
                Random r = new Random();
                for (int i = 0; i < 25; i++)
                {
                    int command = r.Next(3);
                    context.Request(command);
                }
            }
        }
    }
}
