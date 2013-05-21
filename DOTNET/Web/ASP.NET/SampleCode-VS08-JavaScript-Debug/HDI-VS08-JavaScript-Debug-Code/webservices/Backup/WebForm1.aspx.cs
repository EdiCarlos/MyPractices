using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ExerciseSoapReverserExtension
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.TextBox TextBoxName;
		protected System.Web.UI.WebControls.Label label2;
		protected System.Web.UI.WebControls.Button buttonCallHelloWorld;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.buttonCallHelloWorld.Click += new System.EventHandler(this.buttonCallHelloWorld_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void buttonCallHelloWorld_Click(object sender, System.EventArgs e)
		{
			string strToPrint;
			localhost.Service1 svc = new localhost.Service1();
			strToPrint = svc.HelloWorld(this.TextBoxName.Text);
			this.Label1.Text = HttpUtility.HtmlEncode(strToPrint);
		}
	}
}