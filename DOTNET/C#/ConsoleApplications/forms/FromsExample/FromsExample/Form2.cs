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
    public partial class Form2 : Form
    {
        Form1 frm;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 frm)
        {
            InitializeComponent();
            frm.flowLayoutPanel1.Enabled = false;
            this.frm = frm;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            frm.flowLayoutPanel1.Enabled = true;
            base.OnClosing(e);
        }
    }
}
