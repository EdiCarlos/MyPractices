using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BackGroundWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundworker.RunWorkerAsync();
            backgroundworker.WorkerReportsProgress = true;
        }

        private void backgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
               backgroundworker.ReportProgress(i);
            }
           
        }

        private void backgroundworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = (e.ProgressPercentage * 100) / 20;
            toolstriplabel.Text = e.ProgressPercentage.ToString();
           
        }

        private void backgroundworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolstriplabel.Text = "finished";
        }
    }
}
