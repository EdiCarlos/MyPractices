using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseOfLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (this.label1.Width > this.panel1.Width)
            {
                label1.Text.Insert(panel1.Width, "\n");
            }
            this.label1.Text += "\nArifkhan\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
