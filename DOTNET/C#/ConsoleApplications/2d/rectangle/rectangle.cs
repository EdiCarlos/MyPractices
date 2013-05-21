using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data;

class rectangle : Form
{
public rectangle()
{
InitializeComponent();
}
public Form frm;
public void InitializeComponent()
{
this.frm = new Form();
this.frm.Size = new Size(800, 800);
this.ClientSize = new Size(800, 800);
this.Paint += new PaintEventHandler(rect_paint);
}
public static void rect_paint(object sender, PaintEventArgs e)
{
Graphics g = e.Graphics;
Rectangle rect = new Rectangle(200, 200, 500, 400);
g.DrawRectangle(Pens.Blue, rect);
g.DrawString("Arif Khan", new Font("Arial", 20), Brushes.Black, rect);
}
public static void Main()
{
Application.Run(new rectangle());
}
}