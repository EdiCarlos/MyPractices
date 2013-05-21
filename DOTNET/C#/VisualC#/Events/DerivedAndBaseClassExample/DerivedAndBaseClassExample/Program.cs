using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DerivedAndBaseClassExample
{
    /// <summary>
    /// this program defines the example how to call the events declared in base class 
    /// in derived class viz Raise the base class events from derived class
    /// </summary>



    class Program
    {
        static void Main()
        {
            Circle cl = new Circle(10.00);
            Rectangle rect = new Rectangle(2, 3);
            ShapeContainer shape = new ShapeContainer();
            {
                shape.AddShape(cl);
                shape.AddShape(rect);
            }
            cl.Update(11);
            rect.Update(3, 3);
        }
    }

}
