using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePatternShape
{
    public interface Shape
    {
        void renderShapeToScreen();
        Shape[] explodeShape();
    }
    public class Rectangle : Shape
    {
        Shape[] shapes = new Line[] { new Line(-1, -1, 1, 1), new Line(-1, 1, 1, 1), new Line(-1, -1, -1, 1), new Line(1, -1, 1, 1) };

        public void renderShapeToScreen()
        {
            foreach (Shape item in shapes)
            {
                Console.WriteLine("Rendering Rectangle...");
                item.renderShapeToScreen();
            }
        }

        public Shape[] explodeShape()
        {
            return shapes;
        }
    }
    public class Line : Shape
    {
        int point1X, point1Y, point2X, point2Y;
        public Line(int point1X, int point1Y, int point2X, int point2Y)
        {
            this.point1X = point1X;
            this.point1Y = point1Y;
            this.point2X = point2X;
            this.point2Y = point2Y;
        }
        public void renderShapeToScreen()
        {
            Console.WriteLine("Rendering Line...");
            Console.WriteLine("1X:{0},1Y:{1},2X:{2},2Y{3}", point1X, point1Y, point2X, point2Y);
        }

        public Shape[] explodeShape()
        {
            Shape[] shape = { this };
            return shape;
        }
    }

    public class ComplexShape : Shape
    {
        List<Shape> list = new List<Shape>();
        public void addToShape(Shape shape)
        {
            list.Add(shape);
        }
        public void renderShapeToScreen()
        {
            foreach (var item in list)
            {
                Console.WriteLine("Rendering ComplexShapes...");
                item.renderShapeToScreen();
            }
        }

        public Shape[] explodeShape()
        {
            return list.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> allShapes = new List<Shape>();

            Shape line = new Line(1, 1, 1, 1);
            
            allShapes.Add(line);

            ComplexShape complexShape = new ComplexShape();
            complexShape.addToShape(new Line(-1, 1, 1, 1));
            complexShape.addToShape(new Line(-1, -1, 1, 1));
            complexShape.addToShape(new Line(-1, 1, -1, 1));
            complexShape.addToShape(new Line(1, 1, -1, 1));
            complexShape.addToShape(new Line(1, 1, -1, -1));
            complexShape.addToShape(line);

            allShapes.Add(complexShape);

            Rectangle rectAngle = new Rectangle();

            allShapes.Add(rectAngle);

            allShapes.ForEach((s) => { RenderGraphics(s); });
            
            Shape[] shapes = allShapes[0].explodeShape();

        }
        public static void RenderGraphics(Shape line)
        {
            line.renderShapeToScreen();
        }
    }
}
