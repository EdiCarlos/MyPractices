using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapTwoInterfaceEvents
{
    interface IDrawObject
    {
        event EventHandler OnDraw;
    }
    interface IShape
    {
        event EventHandler OnDraw;
    }
    class Shape : IDrawObject, IShape
    {
        event EventHandler PreDrawEvent;
        event EventHandler PostDrawEvent;

        event EventHandler IDrawObject.OnDraw
        {
            add
            {
                lock (PreDrawEvent)
                {
                    PreDrawEvent += value;
                }
            }
            remove
            {
                lock (PreDrawEvent)
                {
                    PreDrawEvent -= value;
                }
            }
        }
        event EventHandler IShape.OnDraw
        {
            add
            {
                lock (PostDrawEvent)
                {
                    PostDrawEvent += value;
                }
            }
            remove
            {
                lock (PostDrawEvent)
                {
                    PostDrawEvent -= value;
                }
            }
        }
        public void Draw()
        {
            EventHandler handler = PreDrawEvent;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }

            Console.WriteLine("Drawing a Shape");

            handler = PostDrawEvent;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }
    }
    class Sub1
    {
        public Sub1(Shape shape)
        {
            IDrawObject obj = (IDrawObject)shape;
            obj.OnDraw += new EventHandler(obj_OnDraw);
        }

        void obj_OnDraw(object sender, EventArgs e)
        {
            Console.WriteLine("Sub receives Idrawing event");
        }
    }
    class Sub2
    {
        public Sub2(Shape shape)
        {
            IShape obj = (IShape)shape;
            obj.OnDraw += new EventHandler(obj_OnDraw);
        }

        void obj_OnDraw(object sender, EventArgs e)
        {
            Console.WriteLine("Sub receives IShape event");
        }
    }

}
