using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FlyWeightPatternSample;

namespace ShowFlyWeightImages
{
    public class Window : Form
    {
        Window()
        {
            this.Height = 600; this.Width = 600; this.Text = "Pictures Groups"; Client client = new Client();
            client.LoadGroups();
            this.Paint += new PaintEventHandler(client.DisplayGroups);
        }
        [STAThread]
        public static void Main()
        {
            Application.Run(new Window());
        }
    }
}
