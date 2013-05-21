using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDictionary
{
    public delegate void EventHandler3(int i);
    public delegate void EventHandler4(string s);

    class PropertyClass1
    {
        Dictionary<string, System.Delegate> eventTable;
        public PropertyClass1()
        {
            eventTable = new Dictionary<string, Delegate>();
            eventTable.Add("Event1", null);
            eventTable.Add("Event2", null);
        }
        public event EventHandler3 Event1
        {
            add
            {
                lock (eventTable)
                {
                    eventTable["Event1"] = (EventHandler3)eventTable["Event1"] + value;
                }
            }
            remove
            {
                lock (eventTable)
                {
                    eventTable["Event1"] = (EventHandler3)eventTable["Event1"] - value;
                }
            }
        }
        public event EventHandler4 Event2
        {
            add
            {
                lock (eventTable)
                {
                    eventTable["Event2"] = (EventHandler4)eventTable["Event2"] + value;
                }
                
            }
            remove
            {
                lock (eventTable)
                {
                    eventTable["Event2"] = (EventHandler4)eventTable["Event2"] - value;
                }
            }
        }
        internal void RaiseEvent1(int i)
        {
            EventHandler3 handler1;
            if(null !=(handler1 = (EventHandler3)eventTable["Event1"]))
            {
                handler1(i);
            }
        }
        internal void RaiseEvent2(string s)
        {
            EventHandler4 handler2;
            handler2 = (EventHandler4)eventTable["Event2"];
            if (handler2 != null)
            {
                handler2(s);
            }
        }
    }
}
