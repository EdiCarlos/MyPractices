using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace wwHTTP
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnHttpWebRequest;
		private System.Windows.Forms.Button cmdwwHTTPForm;
		private System.Windows.Forms.Button cmdMultiThread;
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnHttpWebRequest = new System.Windows.Forms.Button();
			this.cmdwwHTTPForm = new System.Windows.Forms.Button();
			this.cmdMultiThread = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// btnHttpWebRequest
			// 
			this.btnHttpWebRequest.Location = new System.Drawing.Point(29, 16);
			this.btnHttpWebRequest.Name = "btnHttpWebRequest";
			this.btnHttpWebRequest.Size = new System.Drawing.Size(177, 35);
			this.btnHttpWebRequest.TabIndex = 0;
			this.btnHttpWebRequest.Text = "Simple HttpWebRequest";
			this.btnHttpWebRequest.Click += new System.EventHandler(this.btnHttpWebRequest_Click);
			// 
			// cmdwwHTTPForm
			// 
			this.cmdwwHTTPForm.Location = new System.Drawing.Point(29, 57);
			this.cmdwwHTTPForm.Name = "cmdwwHTTPForm";
			this.cmdwwHTTPForm.Size = new System.Drawing.Size(177, 35);
			this.cmdwwHTTPForm.TabIndex = 1;
			this.cmdwwHTTPForm.Text = "wwHTTP Class";
			this.cmdwwHTTPForm.Click += new System.EventHandler(this.cmdwwHTTPForm_Click);
			// 
			// cmdMultiThread
			// 
			this.cmdMultiThread.Location = new System.Drawing.Point(32, 101);
			this.cmdMultiThread.Name = "cmdMultiThread";
			this.cmdMultiThread.Size = new System.Drawing.Size(175, 42);
			this.cmdMultiThread.TabIndex = 2;
			this.cmdMultiThread.Text = "Multi-Thread wwHTTP Example";
			this.cmdMultiThread.Click += new System.EventHandler(this.cmdMultiThread_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Location = new System.Drawing.Point(16, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(201, 145);
			this.panel1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(232, 162);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.cmdMultiThread,
																		  this.cmdwwHTTPForm,
																		  this.btnHttpWebRequest,
																		  this.panel1});
			this.Name = "Form1";
			this.Text = "HTTP Samples";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnHttpWebRequest_Click(object sender, System.EventArgs e)
		{
			wwHTTP.SimpleHttpWebRequest loForm = new wwHTTP.SimpleHttpWebRequest();
			loForm.Show();
		}

		private void cmdwwHTTPForm_Click(object sender, System.EventArgs e)
		{
			wwHTTP.wwHTTPWebForm loForm = new wwHTTP.wwHTTPWebForm();
			loForm.Show();
		}

		private void cmdMultiThread_Click(object sender, System.EventArgs e)
		{
			wwHTTP.wwHttpMultiThread loForm = new wwHTTP.wwHttpMultiThread();
			loForm.Show();
		}
	}
}
