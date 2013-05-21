using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDictionary
{
    public delegate void FNamehandler(string f, string l, string m);

    class MyEvent
    {
         event FNamehandler FNameEvent;

        public event FNamehandler Event1
        {
            add
            {
              
                    FNameEvent += value;
            
            }
            remove
            {
                lock (FNameEvent)
                {
                    FNameEvent -= value;
                }
            }
        }
        internal void RaiseFNameEvent(string f, string l, string m)
        {
            FNamehandler handler = FNameEvent;
            if (handler != null)
            {
                handler(f, l, m);
            }
        }
    }

}
