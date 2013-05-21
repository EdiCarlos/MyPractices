using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomEventExample
{
    class MyButtonEventArgs : EventArgs
    {
        string buttonName;
        object sender;

        public string ButtonName
        {
            get { return buttonName; }
            set { buttonName = value; }
        }

        public object Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        public MyButtonEventArgs(string name)
        {
            buttonName = name;
        }
    }

    class MyButton
    {
        public delegate void MyHandler(object sender, MyButtonEventArgs e);

        public event EventHandler<MyButtonEventArgs> EventButtonClick;
        public event MyHandler EventButtonHover;
        public void OnClick()
        {
            RaiseButtonClick(new MyButtonEventArgs("MyButton"));
        }
        public void OnHover()
        {
            EventButtonHover(this, new MyButtonEventArgs("OnHover"));
        }
        //protected virtual void EventButtonHover(MyButtonEventArgs e)
        //{
        //    if (EventButtonHover != null)
        //    {
        //        EventButtonHover(this, e);
        //    }
        //}
        protected virtual void RaiseButtonClick(MyButtonEventArgs e)
        {
            if (EventButtonClick != null)
            {
                EventButtonClick(this, e);
            }
        }
    }

    class Program
    {
        public Program()
        {
            //MyButton btn = new MyButton();
            //btn.EventButtonClick += new EventHandler<MyButtonEventArgs>(btn_EventButtonClick);
            //btn.OnClick();
            //btn.EventButtonHover += new MyButton.MyHandler(btn_EventButtonHover);
            //btn.OnHover();
            UseButton btn = new UseButton();
            btn.Invoke();
        }

        void btn_EventButtonHover(object sender, MyButtonEventArgs e)
        {
            Console.WriteLine("Button is hovering");
        }

        void btn_EventButtonClick(object sender, MyButtonEventArgs e)
        {
            Console.WriteLine("button Name " + e.ButtonName + "Sender of this event " + sender);
        }
        static void Main()
        {
            Program prog = new Program();
        }
    }
}
