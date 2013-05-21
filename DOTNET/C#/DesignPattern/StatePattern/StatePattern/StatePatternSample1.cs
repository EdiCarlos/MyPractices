using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class StatePatternSample1
    {
       public interface IState
        {
            int MoveUp(Context context);
            int MoveDown(Context context);
        }
        public class Context
        {
            public static int LIMIT = 100;
            public int counter = 0;
            public IState State { get; set; }
            public Context()
            {
                State = new NormalState();
            }
            public int ResultState(int state)
            {
                if (state == 2)
                {
                    return State.MoveUp(this);
                }
                else
                {
                   return  State.MoveDown(this);
                }
            }
        }
        public class NormalState : IState
        {
            #region IState Members

            public int MoveUp(Context context)
            {
                return context.counter + 2;
            }

            public int MoveDown(Context context)
            {
                if (context.counter < Context.LIMIT)
                {
                    context.State = new FastForwardState();
                    Console.Write("||");
                }
                context.counter -= 2;
                return context.counter;
            }

            #endregion
        }
        public class FastForwardState : IState
        {
            #region IState Members

            public int MoveUp(Context context)
            {
                return context.counter  = context.counter + 5;
            }

            public int MoveDown(Context context)
            {
                if (context.counter < Context.LIMIT)
                {
                    context.State = new NormalState();
                    Console.Write("||");
                }
                context.counter -= 5;
                return context.counter;
            }

            #endregion
        }
        public class RunStatePattern
        {
            public static void Run()
            {
                Context context = new Context();
                Random rnd = new Random();
                for (int i = 0; i < Context.LIMIT; i++)
                {
                    Console.Write(context.ResultState(rnd.Next(0, 3)));
                }
            }
        }
    }
}
