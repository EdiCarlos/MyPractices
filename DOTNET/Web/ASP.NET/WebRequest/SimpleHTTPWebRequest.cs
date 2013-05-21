using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Text;

using System.Web;

namespace wwHTTP
{
	/// <summary>
	/// Summary description for SimpleHttpWebRequest.
	/// </summary>
	public class SimpleHttpWebRequest : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.TextBox txtHTML;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdGo;

		private CookieCollection oCookies;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SimpleHttpWebRequest()
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
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.txtHTML = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdGo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtUrl
			// 
			this.txtUrl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUrl.Location = new System.Drawing.Point(39, 4);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(376, 21);
			this.txtUrl.TabIndex = 6;
			this.txtUrl.Text = "http://www.microsoft.com/";
			// 
			// txtHTML
			// 
			this.txtHTML.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtHTML.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtHTML.Location = new System.Drawing.Point(0, 32);
			this.txtHTML.Multiline = true;
			this.txtHTML.Name = "txtHTML";
			this.txtHTML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHTML.Size = new System.Drawing.Size(716, 268);
			this.txtHTML.TabIndex = 5;
			this.txtHTML.Text = "";
			this.txtHTML.WordWrap = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(674, 310);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(3, 2);
			this.button1.TabIndex = 8;
			this.button1.Text = "button1";
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
			this.cmdGo.Location = new System.Drawing.Point(423, 4);
			this.cmdGo.Name = "cmdGo";
			this.cmdGo.Size = new System.Drawing.Size(69, 22);
			this.cmdGo.TabIndex = 10;
			this.cmdGo.Text = "&Go";
			this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
			// 
			// SimpleHttpWebRequest
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(713, 300);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.cmdGo,
																		  this.label1,
																		  this.button1,
																		  this.txtUrl,
																		  this.txtHTML});
			this.Name = "SimpleHttpWebRequest";
			this.Text = "SimpleHTTPWebRequest";
			this.ResumeLayout(false);

		}
		#endregion


		private void cmdGo_Click(object sender, System.EventArgs e)
		{
			// *** Establish request by assigning Url
			HttpWebRequest loHttp = (HttpWebRequest) WebRequest.Create(this.txtUrl.Text.TrimEnd());

			// *** Set any header related and operational properties
			loHttp.Timeout = 10000;  // 10 secs
			loHttp.UserAgent = "Code Sample Web Client";

			// *** reuse cookies if available
			loHttp.CookieContainer = new CookieContainer();

			if (this.oCookies != null && this.oCookies.Count > 0) 
			{
				loHttp.CookieContainer.Add(this.oCookies);
			}

			// *** Return the Response data
			HttpWebResponse loWebResponse = (HttpWebResponse) loHttp.GetResponse();
			
			// ** If the server returns any cookies
			// ** add 'em to our cookies collection
			if (loWebResponse.Cookies.Count > 0)
				if (this.oCookies == null)
				{
					this.oCookies = loWebResponse.Cookies;
				}
				else 
				{
					// ** If we already have cookies update the list
					foreach (Cookie oRespCookie in loWebResponse.Cookies) 
					{
						bool bMatch = false;
						foreach(Cookie oReqCookie in this.oCookies) 
						{
							if (oReqCookie.Name == oRespCookie.Name) 
							{
								oReqCookie.Value = oRespCookie.Name;
								bMatch = true;
								break; // 
							}
						}
						if (!bMatch)
							this.oCookies.Add(oRespCookie);
					}
				}
			
			Encoding enc = Encoding.GetEncoding(1252);  // Windows-1252 or iso-
			if (loWebResponse.ContentEncoding.Length > 0) 
			{
				enc = Encoding.GetEncoding(loWebResponse.ContentEncoding);
			}

			StreamReader loResponseStream = 
				new StreamReader(loWebResponse.GetResponseStream(),enc);
			
			this.txtHTML.Text = loResponseStream.ReadToEnd();

			loResponseStream.Close();
			loWebResponse.Close();
		}

	}
}
