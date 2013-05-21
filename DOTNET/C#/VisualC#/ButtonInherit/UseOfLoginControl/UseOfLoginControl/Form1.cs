using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseOfLoginControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loginControl1.LoginBtnHandler += new EventHandler(loginControl1_LoginBtnHandler);
        }

        void loginControl1_LoginBtnHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Login Button was Clicked");
        }


    }
}
