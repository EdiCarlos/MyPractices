using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Westwind.Tools.Http;
using System.Threading;

namespace wwHTTP
{
	/// <summary>
	/// Summary description for wwHttpMultiThread.
	/// </summary>
	public class wwHttpMultiThread : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdGo;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrl2;
		public System.Windows.Forms.Label lblResult;
		public System.Windows.Forms.Label lblResult2;
		public System.Windows.Forms.ProgressBar oProgress;
		public System.Windows.Forms.ProgressBar oProgress2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public wwHttpMultiThread()
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
				if(components != null)
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
			this.cmdGo = new System.Windows.Forms.Button();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrl2 = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblResult2 = new System.Windows.Forms.Label();
			this.oProgress = new System.Windows.Forms.ProgressBar();
			this.oProgress2 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// cmdGo
			// 
			this.cmdGo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdGo.Location = new System.Drawing.Point(403, 195);
			this.cmdGo.Name = "cmdGo";
			this.cmdGo.Size = new System.Drawing.Size(89, 25);
			this.cmdGo.TabIndex = 12;
			this.cmdGo.Text = "&Go";
			this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
			// 
			// txtUrl
			// 
			this.txtUrl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUrl.Location = new System.Drawing.Point(16, 33);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(475, 21);
			this.txtUrl.TabIndex = 11;
			this.txtUrl.Text = "http://www.west-wind.com/presentations/dotnetwebservices/DotNetWebServices.asp";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "First site Url:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Second site Url:";
			// 
			// txtUrl2
			// 
			this.txtUrl2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUrl2.Location = new System.Drawing.Point(16, 131);
			this.txtUrl2.Name = "txtUrl2";
			this.txtUrl2.Size = new System.Drawing.Size(475, 21);
			this.txtUrl2.TabIndex = 15;
			this.txtUrl2.Text = "http://www.west-wind.com/presentations/dotnetwebservices/DotNetWebServicesData.as" +
				"p";
			// 
			// lblResult
			// 
			this.lblResult.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblResult.Location = new System.Drawing.Point(16, 73);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(475, 22);
			this.lblResult.TabIndex = 16;
			// 
			// lblResult2
			// 
			this.lblResult2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblResult2.Location = new System.Drawing.Point(16, 171);
			this.lblResult2.Name = "lblResult2";
			this.lblResult2.Size = new System.Drawing.Size(475, 12);
			this.lblResult2.TabIndex = 17;
			// 
			// oProgress
			// 
			this.oProgress.Location = new System.Drawing.Point(16, 58);
			this.oProgress.Name = "oProgress";
			this.oProgress.Size = new System.Drawing.Size(475, 14);
			this.oProgress.Step = 5;
			this.oProgress.TabIndex = 18;
			// 
			// oProgress2
			// 
			this.oProgress2.Location = new System.Drawing.Point(16, 156);
			this.oProgress2.Name = "oProgress2";
			this.oProgress2.Size = new System.Drawing.Size(475, 14);
			this.oProgress2.Step = 5;
			this.oProgress2.TabIndex = 19;
			// 
			// wwHttpMultiThread
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(506, 226);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.oProgress2,
																		  this.oProgress,
																		  this.lblResult2,
																		  this.lblResult,
																		  this.txtUrl2,
																		  this.label2,
																		  this.label1,
																		  this.cmdGo,
																		  this.txtUrl});
			this.Name = "wwHttpMultiThread";
			this.Text = "Multi Threaded wwHttp Requests";
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdGo_Click(object sender, System.EventArgs e)
		{
			GetUrls oGetUrls = new GetUrls();
			oGetUrls.Url = this.txtUrl.Text;
			oGetUrls.ParentForm = this;
			
			ThreadStart oDelegate = new ThreadStart(oGetUrls.FireUrls);
			Thread myThread = new Thread(oDelegate);
			myThread.Start();

			GetUrls oGetUrls2 = new GetUrls();
			oGetUrls2.ParentForm = this;
			oGetUrls2.Url = this.txtUrl2.Text;
			oGetUrls2.Instance = 2;
			
			ThreadStart oDelegate2 = new ThreadStart(oGetUrls2.FireUrls);
			Thread myThread2 = new Thread(oDelegate2);
			myThread2.Start();
		}
	}

	public class GetUrls 
	{
		public string Url = "";
		public wwHttpMultiThread ParentForm = null;
		public int Instance = 1;

		public void FireUrls() 
		{
			wwHttp oHttp = new wwHttp();
			oHttp.OnReceiveData += new wwHttp.OnReceiveDataHandler(this.OnReceiveData);
			oHttp.Timeout=5;
			string lcHTML = oHttp.GetUrlEvents(this.Url,4096);
			if (oHttp.Error)
				this.ParentForm.lblResult.Text = oHttp.ErrorMsg;
		}

		public void OnReceiveData(object sender, wwHttp.OnReceiveDataEventArgs e) 
		{
			if (this.Instance == 1) 
			{
				this.ParentForm.lblResult.Text = e.CurrentByteCount.ToString() + " of " + 
					e.TotalBytes.ToString() + " bytes";
				if (e.TotalBytes > 0) 
				{
					this.ParentForm.oProgress.Value = Convert.ToInt32((double) e.CurrentByteCount/(double) e.TotalBytes * 100 );
				}

			}
			else 
			{
				this.ParentForm.lblResult2.Text = e.CurrentByteCount.ToString() + " of " + 
					e.TotalBytes.ToString() + " bytes";
				if (e.TotalBytes > 0) 
				{
					this.ParentForm.oProgress2.Value = Convert.ToInt32((double) e.CurrentByteCount/(double) e.TotalBytes * 100 );
				}
			}
		}


	}

}
