using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Westwind.Tools.Http;
using System.Text;

namespace wwHTTP
{
	/// <summary>
	/// Summary description for SimpleHTTPWebRequest.
	/// </summary>
	public class wwHTTPWebForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.StatusBar oStatus;
		private System.Windows.Forms.StatusBarPanel Panel1;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.TextBox txtHTML;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdGo;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPostData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtRequestHeaders;
		private System.Windows.Forms.TextBox txtResponseHeaders;

		wwHttp oHttp;

		public wwHTTPWebForm()
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
			this.oStatus = new System.Windows.Forms.StatusBar();
			this.Panel1 = new System.Windows.Forms.StatusBarPanel();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.txtHTML = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdGo = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPostData = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRequestHeaders = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtResponseHeaders = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Panel1)).BeginInit();
			this.SuspendLayout();
			// 
			// oStatus
			// 
			this.oStatus.Location = new System.Drawing.Point(0, 511);
			this.oStatus.Name = "oStatus";
			this.oStatus.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					   this.Panel1});
			this.oStatus.ShowPanels = true;
			this.oStatus.Size = new System.Drawing.Size(690, 22);
			this.oStatus.TabIndex = 7;
			this.oStatus.Text = "oStatus";
			// 
			// Panel1
			// 
			this.Panel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.Panel1.Text = "Read";
			this.Panel1.Width = 674;
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(39, 4);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(376, 20);
			this.txtUrl.TabIndex = 6;
			this.txtUrl.Text = "http://msdn.microsoft.com/";
			this.txtUrl.Enter += new System.EventHandler(this.txtUrl_Enter);
			// 
			// txtHTML
			// 
			this.txtHTML.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtHTML.Location = new System.Drawing.Point(0, 211);
			this.txtHTML.Multiline = true;
			this.txtHTML.Name = "txtHTML";
			this.txtHTML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHTML.Size = new System.Drawing.Size(693, 301);
			this.txtHTML.TabIndex = 5;
			this.txtHTML.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 15);
			this.label1.TabIndex = 9;
			this.label1.Text = "Url:";
			// 
			// cmdGo
			// 
			this.cmdGo.Location = new System.Drawing.Point(420, 4);
			this.cmdGo.Name = "cmdGo";
			this.cmdGo.Size = new System.Drawing.Size(89, 23);
			this.cmdGo.TabIndex = 10;
			this.cmdGo.Text = "&Go";
			this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(2, 195);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 11);
			this.label2.TabIndex = 11;
			this.label2.Text = "Result:";
			// 
			// txtPostData
			// 
			this.txtPostData.Location = new System.Drawing.Point(1, 53);
			this.txtPostData.Multiline = true;
			this.txtPostData.Name = "txtPostData";
			this.txtPostData.Size = new System.Drawing.Size(689, 47);
			this.txtPostData.TabIndex = 12;
			this.txtPostData.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(1, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 11);
			this.label3.TabIndex = 13;
			this.label3.Text = "Post Data:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(2, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "HTTP Request Headers:";
			// 
			// txtRequestHeaders
			// 
			this.txtRequestHeaders.Location = new System.Drawing.Point(0, 122);
			this.txtRequestHeaders.Multiline = true;
			this.txtRequestHeaders.Name = "txtRequestHeaders";
			this.txtRequestHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRequestHeaders.Size = new System.Drawing.Size(324, 65);
			this.txtRequestHeaders.TabIndex = 14;
			this.txtRequestHeaders.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(342, 107);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "HTTP Response Headers:";
			// 
			// txtResponseHeaders
			// 
			this.txtResponseHeaders.Location = new System.Drawing.Point(343, 122);
			this.txtResponseHeaders.Multiline = true;
			this.txtResponseHeaders.Name = "txtResponseHeaders";
			this.txtResponseHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResponseHeaders.Size = new System.Drawing.Size(347, 65);
			this.txtResponseHeaders.TabIndex = 16;
			this.txtResponseHeaders.Text = "";
			// 
			// wwHTTPWebForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(690, 533);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label5,
																		  this.txtResponseHeaders,
																		  this.label4,
																		  this.txtRequestHeaders,
																		  this.label3,
																		  this.txtPostData,
																		  this.label2,
																		  this.cmdGo,
																		  this.label1,
																		  this.oStatus,
																		  this.txtUrl,
																		  this.txtHTML});
			this.Name = "wwHTTPWebForm";
			this.Text = "wwHTTP Sample";
			((System.ComponentModel.ISupportInitialize)(this.Panel1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdGo_Click(object sender, System.EventArgs e)
		{

			if ( this.oHttp == null)
				this.oHttp = new wwHttp();

			wwHttp loHttp = this.oHttp;
			
//			loHttp.PostMode = 2;  // UrlEncoded
//			loHttp.HandleCookies = true;
//			if (this.txtPostData.Text.Length > 0)
//				loHttp.AddPostKey(this.txtPostData.Text);
//
//			loHttp.AddPostKey("Name","Rick Strahl ¢");
//			// loHttp.AddPostFile("TestFile",@"d:\temp\test.txt");
//			loHttp.AddPostKey("Company","West Wind Technologies");
//			if (!loHttp.AddPostFile("filename",@"D:\installs\Distribution CD\Products\wwwc_415.exe") )
//			{
//				MessageBox.Show( loHttp.ErrorMsg);
//				return;
//			}


			loHttp.OnReceiveData += new wwHttp.OnReceiveDataHandler(this.loHttp_OnReceiveData);

			// *** 
	        //string lcHtml = loHttp.GetUrl(this.txtUrl.Text.TrimEnd());

			// *** Get data with events using a 4k buffer
		    string lcHtml = loHttp.GetUrlEvents(this.txtUrl.Text.TrimEnd(),4096);
							int lnSize = lcHtml.Length;
		
			if (loHttp.Error) 
			{
				this.txtHTML.Text = loHttp.ErrorMsg;
				this.txtResponseHeaders.Text = "";
				this.txtRequestHeaders.Text = "";
			}
			else 
			{
				
				this.txtHTML.Text = lcHtml;
			   lnSize = lcHtml.Length;
				lnSize = this.txtHTML.Text.Length;
				this.txtRequestHeaders.Text = loHttp.WebRequest.Headers.ToString();
				this.txtResponseHeaders.Text = loHttp.WebResponse.Headers.ToString();
			}

			loHttp.OnReceiveData -= new wwHttp.OnReceiveDataHandler(this.loHttp_OnReceiveData);

		}

		private void loHttp_OnReceiveData(object sender, wwHttp.OnReceiveDataEventArgs e) 
		{
			if (e.Done)
				MessageBox.Show("Download Complete!");
			else if (e.CurrentByteCount >  2000000) {
				MessageBox.Show("Cancelling... download too large.");
				e.Cancel = true;
			}
			else 
				this.oStatus.Panels[0].Text = e.CurrentByteCount.ToString() + " of " + 
					e.TotalBytes.ToString() + " read";
		}

		private void txtUrl_Enter(object sender, System.EventArgs e)
		{
			this.txtUrl.SelectAll();
		}

	}
}
