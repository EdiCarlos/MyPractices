using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlsArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var itor = getControls().Where<Control>(c => c.Name == "textBox3");
            
            //text.Text = "aarif";
        }
        public Control[] getControls()
        {
            HashSet<Control> hash = new HashSet<Control>();
            foreach (Control cntr in this.Controls)
            {
                if (cntr is TextBox)
                    hash.Add(cntr);
            }
            return hash.ToArray<Control>();
        }
    }
}
