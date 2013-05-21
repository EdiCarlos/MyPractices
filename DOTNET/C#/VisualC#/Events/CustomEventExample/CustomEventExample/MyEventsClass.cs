using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomEventExample
{
    class MyEventsClass : EventArgs
    {
        string buttonName;
        object sender;

        public MyEventsClass(string name, object sn)
        {
            buttonName = name;
            sender = sn;
        }
        public object Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        
        public string ButtonName
        {
            get { return buttonName; }
            set { buttonName = value; }
        }
    }
    class MyBtn
    {
        public delegate void ButtonHandler(object sender, MyEventsClass e);
       public event EventHandler<MyEventsClass> EventOnHover;
       public event ButtonHandler buttonClick;
        public MyBtn()
        {

        }
        public void OnClick()
        {
            RaiseOnClick(new MyEventsClass("MyBtn", this));
        }
        public void OnHover()
        {
            RaiseOnHover(new MyEventsClass("MyBtn", this));
        }
        protected virtual void RaiseOnHover(MyEventsClass e)
        {
            if (EventOnHover != null)
            {
                EventOnHover(this, e);
            }
        }
        public virtual void RaiseOnClick(MyEventsClass e)
        {
            if (buttonClick != null)
            {
                buttonClick(this, e);
            }
        }
    }
    class UseButton
    {
        public void Invoke()
        {
            //MyBtn btn = new MyBtn();
            //btn.EventOnHover += new EventHandler<MyEventsClass>(btn_EventOnHover);
            //btn.OnHover();
            //btn.buttonClick += new MyBtn.ButtonHandler(btn_buttonClick);
            //btn.OnClick();
            MBtn btn = new MBtn();
            btn.buttonClick +=new MyBtn.ButtonHandler(btn_buttonClick);
            btn.EnterHandler += new MyHandler(btn_EnterHandler);
            btn.OnClick();
            btn.OnEnter();

        }

        void btn_EnterHandler(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Sender);
        }

      
        void btn_buttonClick(object sender, MyEventsClass e)
        {
            Console.WriteLine("Button click event called");
            Console.WriteLine(e.Sender);
            Console.WriteLine(e.ButtonName);
        }

        void btn_EventOnHover(object sender, MyEventsClass e)
        {
            Console.WriteLine(e.ButtonName);
            Console.WriteLine(e.Sender);
        }
    }
    class MBtn : MyBtn
    {
        public event MyHandler EnterHandler;
        public override void RaiseOnClick(MyEventsClass e)
        {
            Console.WriteLine("MBtn Class called this event");
            Console.WriteLine(e.ButtonName);
            Console.WriteLine(e.Sender);
        }
        public void OnEnter()
        {
            RaiseOnEnter(new MyEventArgs("this is the message from MBtn", this));
        }
        public virtual void RaiseOnEnter(MyEventArgs e)
        {
            if (EnterHandler != null)
            {
                EnterHandler(this, e);
            }
        }
    }
}
