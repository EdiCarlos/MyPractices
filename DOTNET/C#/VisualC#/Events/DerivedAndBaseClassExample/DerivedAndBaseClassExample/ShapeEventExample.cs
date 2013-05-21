using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DerivedAndBaseClassExample
{
    public class ShapeEventArgs : EventArgs
    {
        double newarea;
        public ShapeEventArgs(double area)
        {
            newarea = area;
        }
        public double NewArea
        {
            get { return newarea; }
        }
    }
    public abstract class Shape
    {
        protected double area;

        protected double Area
        {
            get { return area; }
            set { area = value; }
        }
        public abstract void Draw();
        public event EventHandler<ShapeEventArgs> ShapeChanged;

        protected virtual void OnShapeChanged(ShapeEventArgs e)
        {
            EventHandler<ShapeEventArgs> handler = ShapeChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

    class Circle : Shape
    {
        private double radius;
        public Circle(double d)
        {
            radius = d;
            area = 3.14 * radius;
        }
        public void Update(double d)
        {
            radius = d;
            area = 3.14 * radius;
            OnShapeChanged(new ShapeEventArgs(area));
        }
        protected override void OnShapeChanged(ShapeEventArgs e)
        {

            base.OnShapeChanged(e);
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            area = length * width;
        }
        public void Update(double length, double width)
        {
            this.length = length;
            this.width = width;
            area = length * width;
            OnShapeChanged(new ShapeEventArgs(area));
        }
        protected override void OnShapeChanged(ShapeEventArgs e)
        {
            base.OnShapeChanged(e);
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
    class ShapeContainer
    {
        List<Shape> _list;
        public ShapeContainer()
        {
            _list = new List<Shape>();
        }
        public void AddShape(Shape s)
        {
            _list.Add(s);
            s.ShapeChanged += s_ShapeChanged;
        }

        void s_ShapeChanged(object sender, ShapeEventArgs e)
        {
            Shape s = (Shape)sender;
            Console.WriteLine("Received event. Shape area is now {0}", e.NewArea);
            s.Draw();
        }
    }
}
