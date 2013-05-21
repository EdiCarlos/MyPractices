using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SupremeTransport
{
    public partial class LogOutFrm : Form
    {
        Main main;
        public LogOutFrm()
        {
            InitializeComponent();
            ShowName();
        }
        public LogOutFrm(Main main)
        {
            InitializeComponent();
            ShowName();
            this.main = main;
        }

        private void ShowName()
        {
            if (UserLogin.Authenticated)
            {
                label2.Text = UserLogin.UserName;
            }
            else
            {
                label2.Text = "";
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            UserLogin.Authenticated = false;
            Form[] frm = main.MdiChildren;
            foreach (Form f in frm)
            {
                f.Close();
            }
            main.EnableAllToolStrip();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}