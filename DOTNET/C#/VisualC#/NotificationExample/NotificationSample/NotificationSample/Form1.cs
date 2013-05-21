using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotificationSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Minimized))
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                this.Show();
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            notifyIcon1.ShowBalloonTip(10000);
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            //this.Hide();
            e.Cancel = true;
            base.OnClosing(e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
