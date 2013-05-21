using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

namespace FlyWeightPatternSample
{
    public interface IFlyWeight
    {
        void Load(string filename);
        void DisplayImage(PaintEventArgs paint, int row, int col);
    }
    public class FlyWeightPattern :  IFlyWeight
    {
        Image image;
        public void Load(string filename)
        {
            image = new Bitmap(filename);
            image.GetThumbnailImage(100, 100, null, new IntPtr());
        }

        public void DisplayImage(PaintEventArgs paint, int row, int col)
        {
            paint.Graphics.DrawImage(image, col * 100 + 10, row * 130 + 40, 150, 150);
        }
    }
    public class FlyWeightPatternFactory
    {
        Dictionary<string, IFlyWeight> flyWeightFactory = new Dictionary<string, IFlyWeight>();

        public void Clear()
        {
            flyWeightFactory.Clear();
        }
        public IFlyWeight this[string name]
        {
            get
            {
                if (!flyWeightFactory.ContainsKey(name))
                {
                    flyWeightFactory[name] = new FlyWeightPattern();
                }
                return flyWeightFactory[name];
            }
        }
    }
}
