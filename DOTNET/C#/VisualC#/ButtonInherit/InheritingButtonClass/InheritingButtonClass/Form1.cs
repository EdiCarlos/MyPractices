using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InheritingButtonClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mButton1_MouseDownHandler(object sender, MouseEventArgs e)
        {
            MButton btn = sender as MButton;
            MessageBox.Show("Mouse DownHanlder called  Button Id " + btn.Id);
        }

        private void loginControl1_BtnHandler(object sender, EventArgs e)
        {
            MessageBox.Show("login button clicked");
        }

        private void loginControl1_BtnClearHandler(object sender, EventArgs e)
        {
            MessageBox.Show("clear button clicked");
        }

    }
}
