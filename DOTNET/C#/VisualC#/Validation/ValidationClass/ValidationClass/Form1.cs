using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValidationClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.customError1.ControlsToValidate = new Control[] { (Control)this.textBox1, (Control)this.textBox2 };

        }
        bool validate = true;
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.ValidateChildren(ValidationConstraints.None);
            if (customError1.Cancel == true)
            {
                MessageBox.Show("success"); 
            }
            else
            {
                MessageBox.Show("failor");
                customError1.Cancel = true;
            }
        }
        
    }
}
