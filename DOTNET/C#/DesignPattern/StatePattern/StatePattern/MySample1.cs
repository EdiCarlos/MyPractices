using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    class MySample1
    {
        public interface IState
        {
            int MoveUp(Context con);
            int MoveDown(Context con);
        }
        class NormalState : IState
        {
            #region IState Members

            public int MoveUp(Context con)
            {
                con.Counter += 5;
                return con.Counter;
            }

            public int MoveDown(Context con)
            {
                if (con.Counter < Context.LIMIT)
                {
                    con.State = new FastForwardState();
                }
                con.Counter -= 2;
                return con.Counter;
            }

            #endregion
        }
        class FastForwardState : IState
        {
            #region IState Members

            public int MoveUp(Context con)
            {
                con.Counter += 2;
                return con.Counter;
            }

            public int MoveDown(Context con)
            {
                if (con.Counter < Context.LIMIT)
                {
                    con.State = new NormalState();
                }
                con.Counter -= 5;
                return con.Counter;
            }

            #endregion
        }

        public class Context
        {
            public const int LIMIT = 5;
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
                Context con = new Context();
                con.State = new NormalState();
                Random r = new Random();
                for (int i = 0; i < 25; i++)
                {
                    Console.Write(con.Request(r.Next(3)));
                }
            }
        }
    }
}
