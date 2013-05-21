using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SupremeTransport
{
    class PrintingClass
    {
        private int billid;

        public int BillId
        {
            get { return billid; }
            set { billid = value; }
        }

        private SupremeTransport.maindatasetTableAdapters.mainbillTableAdapter mainbillTableAdapter;
        private SupremeTransport.maindatasetTableAdapters.billTableAdapter billTableAdapter;
        private maindataset maindataset;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;

        public PrintingClass()
        {

        }
        public PrintingClass(int mnbillid)
        {
            BillId = mnbillid;
            InitializeComponent();
            OnLoad();
        }

        private void InitializeComponent()
        {
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            //
            //Main DataSet Initialization
            //
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.maindataset = new SupremeTransport.maindataset();
            //
            //Table Adapter Initialization
            //
            this.mainbillTableAdapter = new SupremeTransport.maindatasetTableAdapters.mainbillTableAdapter();
            this.billTableAdapter = new SupremeTransport.maindatasetTableAdapters.billTableAdapter();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
        }
        public void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            this.mainbillTableAdapter.ClearBeforeFill = true;
            this.mainbillTableAdapter.FillMainForReport(maindataset.mainbill, BillId);

            // TODO: This line of code loads data into the 'maindataset.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.ClearBeforeFill = true;
            this.billTableAdapter.FillSelectBillForReport(this.maindataset.bill, BillId);
            //supreme bill dataset
            

            DataTable mainTable = this.maindataset.Tables["mainbill"];
            DataRow row = mainTable.Rows[0];

            //
            //get the bill table from bill dataset
            //
            //MessageBox.Show("Height : " + e.MarginBounds.Height + " Width : " + e.MarginBounds.Width +" x " + e.MarginBounds.X + " Y : " + e.MarginBounds.Y);
            MessageBox.Show(e.PageSettings.PrintableArea.X.ToString() + " " + e.PageSettings.PrintableArea.Y.ToString() + " Width " + e.PageSettings.PrintableArea.Width.ToString() + " Height " + e.PageSettings.PrintableArea.Height.ToString());
            
            DataTable billTable = this.maindataset.Tables["bill"];
            int yAxis = 20;
            for (int i = 0; i < billTable.Rows.Count; i++)
            {
                
                DataRow billrow = billTable.Rows[i];
               
                e.Graphics.DrawString(DateTime.Parse(billrow["billdate"].ToString()).ToShortDateString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(30, (250 + yAxis)));

                e.Graphics.DrawString(billrow["gcnumber"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(120, (250 + yAxis)));

                e.Graphics.DrawString(billrow["chalannumber"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(180, (250 + yAxis)));
                e.Graphics.DrawString(billrow["trucknumber"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(250, (250 + yAxis)));

                e.Graphics.DrawString(billrow["goods"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(340, (250 + yAxis)));
                e.Graphics.DrawString(billrow["bags"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(400, (250 + yAxis)));
                e.Graphics.DrawString(billrow["tone"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(450, (250 + yAxis)));
                e.Graphics.DrawString(billrow["rate"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(500, (250 + yAxis)));
                e.Graphics.DrawString(billrow["amount"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(580, (250 + yAxis)));
                e.Graphics.DrawString(DateTime.Parse(billrow["unloadingdate"].ToString()).ToShortDateString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(670, (250 + yAxis)));
                e.Graphics.DrawString(billrow["billnumber"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(900, (250 + yAxis)));
                yAxis = yAxis + 20;
            }

            //printin mainbill details on forms
            e.Graphics.DrawString(row["debitBillNo"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(750, 10));
            e.Graphics.DrawString(DateTime.Parse(row["billdate"].ToString()).ToShortDateString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(750, 20));
            e.Graphics.DrawString(row["station"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(750, 210));
            e.Graphics.DrawString(row["partyName"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(200, 210));
            e.Graphics.DrawString(row["TotalInWords"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(200, 500));
            e.Graphics.DrawString(row["TotalBags"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(450, 480));
            e.Graphics.DrawString(row["TotalTones"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(500, 480));
            e.Graphics.DrawString(row["serviceCharge"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(300, 550));
            e.Graphics.DrawString(row["hsServiceCharge"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(300, 570));
            e.Graphics.DrawString(row["surcharge"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(300, 590));
            e.Graphics.DrawString(row["total"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new PointF(300, 610));
            e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle((int)e.PageSettings.PrintableArea.X,(int) e.PageSettings.PrintableArea.Y, (int) e.PageSettings.PrintableArea.Width,(int) e.PageSettings.PrintableArea.Height));

        }
        private void OnLoad()
        {
            PrinterSettings setting = new PrinterSettings();
            //setting.DefaultPageSettings.Landscape = true;
            //setting.DefaultPageSettings.PaperSize = new PaperSize("custom paper", 50, 50);
            //PaperSize pSize = new PaperSize();
            PageSettings pageSettings = new PageSettings();
            Margins margins = new Margins();

            //pSize.RawKind = 40;
            margins.Right = 0;
            margins.Left = 0;
            margins.Top = 0;
            margins.Bottom = 0;

            pageSettings.PaperSize = new PaperSize("MyPaper", 1200, 800);
            //setting.DefaultPageSettings.PaperSize = 
           // pSize.Kind = PaperKind.GermanLegalFanfold;

            //printDocument1.PrinterSettings = setting;
           
            //setting.DefaultPageSettings.PaperSize = 
           // setting.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.High;
            
            printDocument1.DefaultPageSettings.PrinterSettings = setting;
            printDocument1.DefaultPageSettings = pageSettings;
         //   setting.DefaultPageSettings.PaperSize = pageSettings;
            //setting.DefaultPageSettings.PaperSize.Kind = PaperKind.GermanLegalFanfold;
//            MessageBox.Show(setting.DefaultPageSettings.PrintableArea.Size.Height + " " + setting.DefaultPageSettings.PrintableArea.Size.Width);
         
            //setting.DefaultPageSettings.Bounds = new Rectangle(800, 1200, 1200, 800);
            ////System.IO.StreamWriter write = new System.IO.StreamWriter(@"c:\myfile.txt");
            //for (int i = 0; i < printDocument1.PrinterSettings.PaperSizes.Count; i++)
            //{
               
            //     pSize = printDocument1.PrinterSettings.PaperSizes[i];
            //     write.WriteLine("Height " + pSize.Height.ToString() + " Width : " + pSize.Width.ToString() + " Paper Name " + pSize.PaperName.ToString() + " Raw Kind " + pSize.RawKind.ToString());
            //}
            //write.Close();

            // TODO: This line of code loads data into the 'maindataset.mainbill' table. You can move, or remove it, as needed.
        
            //setting.DefaultPageSettings.Margins = margins;
            //MessageBox.Show("Page bound x : " + setting.DefaultPageSettings.Bounds.Size.Width + " " + setting.DefaultPageSettings.Bounds.Size.Height); 
            this.printPreviewDialog1.Document = printDocument1;
            this.printPreviewDialog1.Show();

        }
    }
}
