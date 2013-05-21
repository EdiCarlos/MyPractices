using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomValidationSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(string.Empty))
            {
                MessageBox.Show("Test");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Focus();
                if (control.HasChildren)
                {
                    if (ValidateChildren())
                    {
                        DialogResult = DialogResult.None;
                        return;
                    }
                }
                else if (Validate())
                {
                    DialogResult = DialogResult.None;
                }
                else
                {
                   
                }
            }
        }
    }
}

