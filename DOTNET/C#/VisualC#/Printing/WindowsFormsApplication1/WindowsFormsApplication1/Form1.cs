using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList column = new ArrayList();

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Inch;
            Single leftmargin = e.MarginBounds.Left / 100;
            Single rightmargin = e.MarginBounds.Right / 100;
            Single topmargin = e.MarginBounds.Top / 100;
            Single bottomMargin = e.MarginBounds.Bottom / 100;
            Single width = e.MarginBounds.Width / 100;
            Single height = e.MarginBounds.Height / 100;
            PrintDoc();
        }
        public void PrintDoc()
        {
            column.Clear();
            ColumnInformation title = new ColumnInformation("title", 2, StringAlignment.Near);
            ColumnInformation author = new ColumnInformation("author", 2, StringAlignment.Near);
            ColumnInformation currency = new ColumnInformation("100.00", 2, StringAlignment.Near);
            currency.FormatColumn += new ColumnInformation.FormatHandler(currency_FormatColumn);
            column.Add(currency);
        }

        void currency_FormatColumn(object sender, FormatColumnEventArgs e)
        {
            Single incomingvalue;
            string outgoingValue;
            incomingvalue = Convert.ToSingle(e.Originalvalue);
            outgoingValue = String.Format("{0:C}", incomingvalue);
            e.StringValue = outgoingValue;
        }

        
    }
    class ColumnInformation
    {
        string field, headertext;

        public string Field
        {
            get { return field; }
            set { field = value; }
        }

        public string Headertext
        {
            get { return headertext; }
            set { headertext = value; }
        }
        StringAlignment alignment;

        public StringAlignment Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        }
        Font headerfont;

        public Font Headerfont
        {
            get { return headerfont; }
            set { headerfont = value; }
        }
        Single width;

        public Single Width
        {
            get { return width; }
            set { width = value; }
        }
        public delegate void FormatHandler(object sender, FormatColumnEventArgs e);
        public event FormatHandler FormatColumn;
        public ColumnInformation(string fields, Single width, StringAlignment alignment)
        {
            field = fields;
            this.width = width;
            this.alignment = alignment;
        }
        public string GetString(object var)
        {
            FormatColumnEventArgs e = new FormatColumnEventArgs();
            e.Originalvalue = var;
            e.StringValue = Convert.ToString(var);
            FormatColumn(this, e);
            return e.StringValue;
        }
        
    }
    class FormatColumnEventArgs : EventArgs
    {
        string stringValue;
        object originalvalue;
        public FormatColumnEventArgs()
        {

        }
        
        public FormatColumnEventArgs(object sender, string str)
        {
            StringValue = str;
            originalvalue = sender;
        }
        public object Originalvalue
        {
            get { return originalvalue; }
            set { originalvalue = value; }
        }
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
        
    }
}
