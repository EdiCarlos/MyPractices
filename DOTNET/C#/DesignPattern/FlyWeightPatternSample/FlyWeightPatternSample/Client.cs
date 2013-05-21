using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

namespace FlyWeightPatternSample
{
    public class Client
    {
        static FlyWeightPatternFactory albums = new FlyWeightPatternFactory();
        static Dictionary<string, List<string>> allGroups = new Dictionary<string, List<string>>();
        public void LoadGroups()
        {
            var groups = new[]{new { Name = "Garden", Members = new [] {"Rose.jpg", "Lily.jpg"}},
                new {Name = "Italy", Members = new [] {"Col.jpg", "Tower.jpg"}},
                new {Name = "Food", Members = new [] {"pizza.jpg", "Burger.jpg"}},
                new {Name = "Friends", Members = new []{"Friend1.jpg", "Fingers.jpg"}}};

            foreach (var item in groups)
            {
                allGroups.Add(item.Name, new List<string>());
                foreach (string fileName in item.Members)
                {
                    allGroups[item.Name].Add(fileName);
                    albums[fileName].Load(fileName);
                }
            }
        }

        public void DisplayGroups(object source, PaintEventArgs e)
        {
            int row = 0;
            foreach (var item in allGroups.Keys)
            {
                int col = 0;
                e.Graphics.DrawString(item, new Font("Arial", 16), new SolidBrush(Color.Black), new PointF(0, row * 130 + 10)); 
                foreach (string item1 in allGroups[item])
                {
                    albums[item1].DisplayImage(e, row, col);
                    col++;
                }
                row++;
            }
        }
    }
}
