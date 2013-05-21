using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace printerResolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            PrinterSettings setting = new PrinterSettings();
            PageSettings pageSetting = new PageSettings();
            Margins margin = new Margins(200, 200, 200, 200);
            
            setting.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.High;
            
            pageSetting.PaperSize = new PaperSize("mypaper", 1200, 800);
            setting.DefaultPageSettings.PaperSize = new PaperSize("mypaper", 1200, 800);
            setting.PrintToFile = true;
            setting.PrintFileName = @"d:\documents and settings\axkhan2\desktop\myfile.tiff";
           
            printDocument1.DefaultPageSettings.PrinterSettings = setting;
            printDocument1.DefaultPageSettings = pageSetting;
            printDocument1.DefaultPageSettings.Margins = margin;
            
            printPreviewDialog1.Document = printDocument1;
          
            printPreviewDialog1.ShowDialog();
            //ShowPrintableArea();
            this.Close();
        }

        private void ShowPrintableArea()
        {

            float height = printDocument1.DefaultPageSettings.PrintableArea.Height;
            float width = printDocument1.DefaultPageSettings.PrintableArea.Width;
            float showX = printDocument1.DefaultPageSettings.PrintableArea.X;
            float showY = printDocument1.DefaultPageSettings.PrintableArea.Y;
            MessageBox.Show("Height " + height + " width " + width + " showX " + showX + " show Y " + showY);
            int rX = printDocument1.DefaultPageSettings.PrinterResolution.X;
            int rY = printDocument1.DefaultPageSettings.PrinterResolution.Y;
            string resolutionKind = printDocument1.DefaultPageSettings.PrinterResolution.Kind.ToString();
            MessageBox.Show(" X " + rX + " Y " + rY + " resolution kind " + resolutionKind  );

            string resolution = String.Empty;
            for (int i = 0; i < printDocument1.PrinterSettings.PrinterResolutions.Count - 1; i++)
            {
                resolution += printDocument1.PrinterSettings.PrinterResolutions[i].ToString() + " \n";
            }
            MessageBox.Show(resolution);
            
        }
        public void useparameter()
        {
            string fname, lname, mname;
            fname = "arif";
            lname = "khan";
            mname = "hasna";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float graphicWidth  = e.PageSettings.PrintableArea.Width;
            float graphicHeight = e.PageSettings.PrintableArea.Height;
            float graphicTop = e.PageSettings.PrintableArea.Top;
            float graphicBottom = e.PageSettings.PrintableArea.Bottom;
            float x = e.PageSettings.PrintableArea.X;
            float y = e.PageSettings.PrintableArea.Y;
            
            MessageBox.Show(" Width " + graphicWidth + " height " + graphicHeight + " top " + graphicTop + " bottom " + graphicBottom + " x " + x + " Y " + y );

            string str = "helloooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
            str += "oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
            Font fnt = new Font("Arial", 10, FontStyle.Regular); 
           
            e.Graphics.DrawString(str, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new RectangleF(100, 100, 100, 100), new StringFormat(StringFormatFlags.FitBlackBox));
            //e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle((int)e.PageSettings.PrintableArea.X,(int) e.PageSettings.PrintableArea.Y, (int)e.PageSettings.PrintableArea.Width,(int) e.PageSettings.PrintableArea.Height));
            //e.Graphics.DrawRectangle(new Pen(Brushes.Blue), new Rectangle((int)e.PageSettings.PrintableArea.Left - e.PageSettings.Margins.Left, (int)e.PageSettings.PrintableArea.Bottom - e.PageSettings.Margins.Bottom, (int)e.PageSettings.PrintableArea.Top - e.PageSettings.Margins.Top,(int)e.PageSettings.PrintableArea.Right - e.PageSettings.Margins.Right));

            e.Graphics.DrawLine(new Pen(Brushes.Black), 100, 100, 300, 300);
            e.Graphics.DrawLine(new Pen(Brushes.Blue), new Point(600, 0), new Point(600, 500));
        }
    }
}
