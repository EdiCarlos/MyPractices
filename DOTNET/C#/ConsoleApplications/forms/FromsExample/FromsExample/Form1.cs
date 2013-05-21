using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FromsExample
{
    public partial class Form1 : Form
    {
        int lastKeyCode = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.Control == true && e.KeyCode == Keys.A && e.KeyCode == Keys.C)
            {
                lastKeyCode = (int)e.KeyCode;
            }
            else
            {
                if (e.KeyCode == Keys.C && lastKeyCode == 65)
                {
                    e.SuppressKeyPress = true;
                    this.textBox2.Focus();
                }
            }
        }
    }
}
