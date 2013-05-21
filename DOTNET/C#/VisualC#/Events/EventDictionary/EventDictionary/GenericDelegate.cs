using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDictionary
{
    public delegate void Mydel<T>(int i);
  
    public struct myt<T> where T : EventArgs
    {
    }
    public class GenericDelegate<T> where T : EventArgs
    {
        public delegate void Mydel1<T>(object sender, T t);
        public event Mydel1<T> GEvent;
        public void RaiseGEVent(object sender, T t)
        {
            Mydel1<T> del = GEvent;
            if (del != null)
            {
                del(this, t);
            }
        }
    }
    class GenericDelegate
    {
  
        event Mydel<EventHandler1> Event1;
        event EventHandler<EventArgs> myevent;
        
        public event Mydel<EventHandler1> EventUseOf1
        {
            add
            {
                Event1 += value;
            }
            remove
            {
                Event1 -= value;
            }
        }
        public GenericDelegate()
        {

        }
        public void raiseEvent(int i)
        {
            Mydel<EventHandler1> handler = Event1;
            if (handler != null)
            {
                handler(i);
            }
        }
        public void raiseMyEvent(object sender, EventArgs e)
        {
            EventHandler<EventArgs> handler = myevent;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }
    }
}
