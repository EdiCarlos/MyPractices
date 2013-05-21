using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data;

namespace Print
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmPrint : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem miFile;
		private System.Windows.Forms.MenuItem miSetup;
		private System.Windows.Forms.MenuItem miPreview;
		private System.Windows.Forms.MenuItem miPrint;
		private int linesPrinted;
        private string[] lines;
		
		public frmPrint()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPrint));
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.miFile = new System.Windows.Forms.MenuItem();
			this.miSetup = new System.Windows.Forms.MenuItem();
			this.miPreview = new System.Windows.Forms.MenuItem();
			this.miPrint = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(8, 16);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(296, 240);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "richTextBox1";
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			// 
			// printDocument1
			// 
			this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.OnBeginPrint);
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.OnPrintPage);
			// 
			// pageSetupDialog1
			// 
			this.pageSetupDialog1.Document = this.printDocument1;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(88, 116);
			this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Opacity = 1;
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miFile});
			// 
			// miFile
			// 
			this.miFile.Index = 0;
			this.miFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.miSetup,
																				   this.miPreview,
																				   this.miPrint});
			this.miFile.Text = "File";
			// 
			// miSetup
			// 
			this.miSetup.Index = 0;
			this.miSetup.Text = "Page Setup";
			this.miSetup.Click += new System.EventHandler(this.miSetup_Click);
			// 
			// miPreview
			// 
			this.miPreview.Index = 1;
			this.miPreview.Text = "Print Preview";
			this.miPreview.Click += new System.EventHandler(this.miPreview_Click);
			// 
			// miPrint
			// 
			this.miPrint.Index = 2;
			this.miPrint.Text = "Print";
			this.miPrint.Click += new System.EventHandler(this.miPrint_Click);
			// 
			// frmPrint
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.ClientSize = new System.Drawing.Size(320, 277);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox1});
			this.Menu = this.mainMenu1;
			this.Name = "frmPrint";
			this.Text = "Simple Print";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmPrint());
		}
        // Form Load
		private void Form1_Load(object sender, System.EventArgs e)
		{
		    // Write to richTextBox
			richTextBox1.Text = "                               " + 
				DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + 
				DateTime.Now.Year + "\r\n\r\n";
			richTextBox1.AppendText("This is a greatly simplified Print " + 
				"Document Method\r\n\r\n");
			richTextBox1.AppendText("We can write text to a richTextBox, " + 
				"or use Append Text," + "\r\n" + "or Concatenate a String, and " + 
				"write that textBox. The " + "\r\n" + "richTextBox does not " + 
				"even have to be visible. " + "\r\n\r\n" + "Because we use a " + 
				"richTextBox it's physical dimensions are " + "\r\n" +
		        "irrelevant. We can place it anywhere on our form, and set the " + 
                "\r\n" + "Visible Property to false.\r\n\r\n");
			richTextBox1.AppendText("This is the document we will print. The " + 
                "rich TextBox serves " + "\r\n" + "as a Cache for our Report, " +
				"or any other text we wish to print.\r\n\r\n");
			richTextBox1.AppendText("I have also included Print Setup " +
				"and Print Preview. ");
		}
        // Print Event
		private void miPrint_Click(object sender, System.EventArgs e)
		{
			if (printDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}
		
		// OnBeginPrint 
		private void OnBeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{
			char[] param = {'\n'};

			if (printDialog1.PrinterSettings.PrintRange == PrintRange.Selection)
			{
				lines = richTextBox1.SelectedText.Split(param);
			}
			else
			{
				lines = richTextBox1.Text.Split(param);
			}
			
			int i = 0;
			char[] trimParam = {'\r'};
			foreach (string s in lines)
			{
				lines[i++] = s.TrimEnd(trimParam);
			}
		}
        // OnPrintPage
		private void OnPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			int x = e.MarginBounds.Left;
			int y = e.MarginBounds.Top;
			Brush brush = new SolidBrush(richTextBox1.ForeColor);
			
			while (linesPrinted < lines.Length)
			{
				e.Graphics.DrawString (lines[linesPrinted++],
					richTextBox1.Font, brush, x, y);
				y += 15;
				if (y >= e.MarginBounds.Bottom)
				{
					e.HasMorePages = true;
					return;
				}
			}
			
			linesPrinted = 0;
			e.HasMorePages = false;
		}
        // Page Setup
		private void miSetup_Click(object sender, System.EventArgs e)
		{
			// Call Dialog Box
			pageSetupDialog1.ShowDialog();
		}
        // Print Preview
		private void miPreview_Click(object sender, System.EventArgs e)
		{
			// Call Dialog Box
			printPreviewDialog1.ShowDialog();
		}
    }
}
