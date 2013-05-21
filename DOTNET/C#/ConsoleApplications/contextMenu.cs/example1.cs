using System;
using System.Windows.Forms;
using System.Windows;
using System.Drawing;

partial class winFrom : System.Windows.Forms.Form
{
	private TextBox text;
  private TextBox text1;	
	public winFrom()
	{
		InitializeComponent();
	}
	public void InitializeComponent()
	{
	//text
	text = new TextBox();
	text.Name = "textBox1";
	text.Location = new Point(0, 50);
	text.Size = new Size(120, 30);
   
   //text
	text1 = new TextBox();
	text1.Name = "text1Box1";
	text1.Location = new Point(0, 80);
	text1.Size = new Size(120, 30);
   
  //context menu
   ContextMenu textcon = new ContextMenu();
   text.ContextMenu = textcon;
   text1.ContextMenu = textcon;
   
   MenuItem item1 = new MenuItem();
   MenuItem item2 = new MenuItem();
   MenuItem item3 = new MenuItem();
   
   item1.Text = "&Copy";
   item2.Text = "&Paste";
   item3.Text = "&Delete";
   item1.Click += new EventHandler(CopyMenuItem1_Clicked);
   item2.Click += new EventHandler(CopyMenuItem2_Clicked);
   item3.Click += new EventHandler(CopyMenuItem3_Clicked);
   
   textcon.MenuItems.Add(item1);
   textcon.MenuItems.Add(item2);
   textcon.MenuItems.Add(item3);
   

		ContextMenu con = new ContextMenu();
		this.ContextMenu = con;
//  con += new EventHandler(contextMenuClicked);
		MenuItem menu1 = new MenuItem();
		MenuItem menu2 = new MenuItem();
		MenuItem close = new MenuItem();
		menu1.Click += new EventHandler(menu1ItemClicked);
		menu2.Click += new EventHandler(menu2ItemClicked);
		close.Click += new EventHandler(menu3ItemClicked);
		
		menu1.Text = "&Add";
		menu2.Text = "&Delete";
		close.Text = "&Close";
		
		con.MenuItems.Add(menu1);
		con.MenuItems.Add(menu2);
		con.MenuItems.Add(close);

 this.Text = "This is Clip box example";
 this.Name = "Form1";

    this.Controls.Add(text);
    this.Controls.Add(text1);
	}
	public void CopyMenuItem1_Clicked(object sender, EventArgs e)
	{
		if(text.Text != string.Empty)
		{
			    Clipboard.SetText(text.Text);
			  }
			  if(text1.Text != string.Empty)
			  {
			  	Clipboard.SetText(text1.Text);
			  }
	}
	public void CopyMenuItem2_Clicked(object sender, EventArgs e)
	{
		if(text1.Text == string.Empty)
		{
		text1.Text = Clipboard.GetText();
	}
	if(text.Text == string.Empty)
	{
		text.Text = Clipboard.GetText();
	}
	}
	public void CopyMenuItem3_Clicked(object sender, EventArgs e)
	{
		if(text1.Text != string.Empty)
		{
			text1.Text = string.Empty;
		}
		if(text.Text != string.Empty)
		{
			text.Text = string.Empty;
		}
	}
	
	public void menu1ItemClicked(object sender, EventArgs e)
	{
		MessageBox.Show("menuClicked");
		
	}
	public void menu3ItemClicked(object sender, EventArgs e)
	{
		this.Close();
	}
	public void menu2ItemClicked(object sender, EventArgs e)
	{
		MessageBox.Show("menuClicked");
		
	}
	
  [STAThread]
  static void Main()
  {
  	Application.Run(new winFrom());
  }
}