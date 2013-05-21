using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns
{
    class CompositePattern
    {
        interface IShape
        {
            void RenderShape();
            IShape[] Explode();
        }
        class Line : IShape
        {

            int X1, X2, Y1, Y2;
            public Line(int x1, int x2, int y1, int y2)
            {
                X1 = x1;
                X2 = x2;
                Y1 = y1;
                Y2 = y2;
            }
            public void RenderShape()
            {
                Console.WriteLine("X1 = {0}; Y1 = {1}; X2 = {2}; Y2 = {3}", X1, Y1, X2, Y2);
            }

            public IShape[] Explode()
            {
                return new Line[] { new Line(X1, X2, Y1, Y2) };
            }
        }

        class Rectangle : IShape
        {
            IShape[] rectangle;

            public Rectangle()
            {
                rectangle = new IShape[4];
                rectangle[0] = new Line(1, 1, 2, 2);
                rectangle[1] = new Line(2, 2, 1, 1);
                rectangle[2] = new Line(0, 0, 1, 1);
                rectangle[3] = new Line(1, 1, 0, 0);
            }
            public void RenderShape()
            {
                for (int i = 0; i < 3; i++)
                {
                    rectangle[i].RenderShape();
                }
            }
            public IShape[] Explode()
            {
                return rectangle; 
            }
        }

        class ComplexShape : IShape
        {
            List<IShape> shapes;
            public ComplexShape()
            {
                shapes = new List<IShape>();
            }
            public void AddShape(Line shape)
            {
                shapes.Add(shape);
            }
            public void RenderShape()
            {
                foreach (IShape item in shapes)
                {
                    item.RenderShape();
                }
            }

            public IShape[] Explode()
            {
                return shapes.ToArray();
            }
        }

        public class UseOfComposite
        {
            public static void Composite()
            {
                IShape line = new Line(0, 0, 1, 1);
                Console.WriteLine("Rendering Line");
                line.RenderShape();
                Console.WriteLine("Rendering Rectangle");
                IShape Rectangle = new Rectangle();
                Rectangle.RenderShape();
                IShape complexShape = new ComplexShape();
                ((ComplexShape)complexShape).AddShape(new Line(0, 1, 1, 1));
                ((ComplexShape)complexShape).AddShape(new Line(0, 1, 1, 1));
                ((ComplexShape)complexShape).AddShape(new Line(0, 1, 1, 1));
                ((ComplexShape)complexShape).AddShape(new Line(0, 1, 1, 1));
                ((ComplexShape)complexShape).AddShape(new Line(0, 1, 1, 1));
                Console.WriteLine("Rendering Complex Shape");
                complexShape.RenderShape();
            }
        }
    }

    class CompositePattern1
    {
        //abstract class Component
        //{
        //    public abstract void Add(Component component);
        //    public abstract void Remove(Component component);
        //}
        interface IComponent
        {
            string Name { get; set; }
            void Add(IComponent comp);
            void Remove(IComponent comp);
            void Display(int depth);
        }
        class Composite : IComponent
        {
            List<IComponent> _children;
            public Composite(string Name)
            {
                _children = new List<IComponent>();
                this.Name = Name;
            }
            public string Name
            {
                get;
                set;
            }
            public void Add(IComponent comp)
            {
                _children.Add(comp);
            }

            public void Remove(IComponent comp)
            {
                _children.Remove(comp);
            }

            public void Display(int depth)
            {
                Console.WriteLine(new String('-', depth) + Name);
                foreach (IComponent item in _children)
                {
                    item.Display(depth + 2);
                }
            }
        }

        class Leaf : IComponent
        {
            public string Name
            {
                get;
                set;
            }
            public Leaf(string name)
            {
                Name = name;
            }

            public void Add(IComponent comp)
            {
                Console.WriteLine("Cannot add leaf");
            }

            public void Remove(IComponent comp)
            {
                Console.WriteLine("Cannot remove leaf");
            }

            public void Display(int depth)
            {
                Console.WriteLine(new String('-', depth) + Name);
            }
        }

        public class UseOfComposite1
        {
            public static void Composite()
            {
                IComponent root = new Composite("root");
                root.Add(new Leaf("Leaf A"));
                root.Add(new Leaf("Leaf B"));
                root.Add(new Leaf("Leaf C"));
                Composite comp = new Composite("Composite X");
                comp.Add(new Leaf("Leaf XA"));
                comp.Add(new Leaf("Leaf XB"));
                comp.Add(new Leaf("Leaf XC"));

                root.Add(comp);
                root.Add(new Leaf("Leaf D"));
                Leaf leaf = new Leaf("Leaf Remove");
                root.Add(leaf);
                root.Remove(leaf);

                root.Display(1);

            }
        }

    }
}
