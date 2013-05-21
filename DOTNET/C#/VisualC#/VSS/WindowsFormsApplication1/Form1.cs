using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            label1.Text = "VSS testing";
            label1.Text = "VSS testing";
            label1.Text = "VSS testing1";
             //todo: write code for login 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test1");
            //todo: write code for login
        }
    }
}
