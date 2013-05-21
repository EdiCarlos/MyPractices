using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace com.fabioscagliola.Downloader
{
   public class Download
   {
      private string source;
      private string target;

      public Download(string source, string target)
      {
         this.source = source;
         this.target = target;
      }

      public void Do(BackgroundWorker worker, DoWorkEventArgs e)
      {
         int range = 0;
         if (File.Exists(this.target))
            range = (int)new FileInfo(this.target).Length;
         HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(this.source);
         httpWebRequest.AddRange(range);
         HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
         Stream responseStream = httpWebResponse.GetResponseStream();
         FileMode access = range > 0 ? FileMode.Append : FileMode.Create;
         FileStream fileStream = new FileStream(this.target, access);
         byte[] b = new byte[2048];
         while (true)
         {
            if (worker.CancellationPending)
            {
               e.Cancel = true;
               break;
            }
            int n = responseStream.Read(b, 0, b.Length);
            if (n > 0)
            {
               fileStream.Write(b, 0, n);
               worker.ReportProgress((int)((float)fileStream.Length / (range + httpWebResponse.ContentLength) * 100));
            }
            else
               break;
         }
         responseStream.Close();
         fileStream.Close();
      }
   }

   public class DownloadForm : Form
   {
      private BackgroundWorker backgroundWorker1 = new BackgroundWorker();
      private Label label1 = new Label();
      private Label label2 = new Label();
      private TextBox textBox1 = new TextBox();
      private TextBox textBox2 = new TextBox();
      private ProgressBar progressBar1 = new ProgressBar();
      private Button button1 = new Button();
      private Button button2 = new Button();

      public DownloadForm()
      {
         this.SuspendLayout();

         this.backgroundWorker1.WorkerReportsProgress = true;
         this.backgroundWorker1.WorkerSupportsCancellation = true;
         this.backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
         this.backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
         this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

         this.label1.Location = new Point(8, 8);
         this.label1.Size = new Size(304, 16);
         this.label1.TabIndex = 0;
         this.label1.Text = "&Source";

         this.textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
         this.textBox1.Location = new Point(8, 24);
         this.textBox1.Size = new Size(304, 16);
         this.textBox1.TabIndex = 1;

         this.label2.Location = new Point(8, 48);
         this.label2.Size = new Size(304, 16);
         this.label2.TabIndex = 2;
         this.label2.Text = "&Target";

         this.textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
         this.textBox2.Location = new Point(8, 64);
         this.textBox2.Size = new Size(304, 16);
         this.textBox2.TabIndex = 3;

         this.progressBar1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
         this.progressBar1.Location = new Point(8, 96);
         this.progressBar1.Size = new Size(304, 16);
         this.progressBar1.Style = ProgressBarStyle.Continuous;
         this.progressBar1.TabIndex = 4;

         this.button1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
         this.button1.Location = new Point(176, 128);
         this.button1.Size = new Size(64, 24);
         this.button1.TabIndex = 5;
         this.button1.Text = "St&art";
         this.button1.Click += new EventHandler(this.button1_Click);

         this.button2.Anchor = AnchorStyles.Right | AnchorStyles.Top;
         this.button2.Enabled = false;
         this.button2.Location = new Point(248, 128);
         this.button2.Size = new Size(64, 24);
         this.button2.TabIndex = 6;
         this.button2.Text = "St&op";
         this.button2.Click += new EventHandler(this.button2_Click);

         this.ClientSize = new Size(320, 160);
         this.Controls.Add(this.progressBar1);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.textBox2);
         this.MinimumSize = this.Size;
         this.StartPosition = FormStartPosition.CenterScreen;
         this.Text = Application.ProductName;

         this.ResumeLayout(false);
      }

      private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
      {
         Download download = new Download(textBox1.Text, textBox2.Text);
         download.Do(sender as BackgroundWorker, e);
      }

      private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
      {
         this.progressBar1.Value = e.ProgressPercentage;
      }

      private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
      {
         if (e.Cancelled)
         {
            // Do nothing
         }
         else if (e.Error != null)
         {
            MessageBox.Show(e.Error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         else
         {
            MessageBox.Show("Download completed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.button1.Enabled = false;
         this.button2.Enabled = true;
         backgroundWorker1.RunWorkerAsync();
         while (this.backgroundWorker1.IsBusy)
            Application.DoEvents();
         this.button1.Enabled = true;
         this.button2.Enabled = false;
      }

      private void button2_Click(object sender, EventArgs e)
      {
         this.backgroundWorker1.CancelAsync();
      }

      [STAThread]
      static void Main()
      {
         Application.Run(new DownloadForm());
      }
   }
}
