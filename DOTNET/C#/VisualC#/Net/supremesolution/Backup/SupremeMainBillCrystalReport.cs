using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SupremeTransport
{
    public partial class SupremeMainBillCrystalReport : Form
    {
        private int billid;

        public int Billid
        {
            get { return billid; }
            set { billid = value; }
        }
        public SupremeMainBillCrystalReport()
        {
            InitializeComponent();
        }
        public SupremeMainBillCrystalReport(int billid)
        {
            InitializeComponent();
            Billid = billid;
        }

        private void SupremeMainBillCrystalReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maindataset.mainbill' table. You can move, or remove it, as needed.
            this.mainbillTableAdapter.ClearBeforeFill = true;
            this.mainbillTableAdapter.FillMainForReport(maindataset.mainbill, Billid);

            // TODO: This line of code loads data into the 'maindataset.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.ClearBeforeFill = true;
            this.billTableAdapter.FillSelectBillForReport(this.maindataset.bill, Billid);
            this.billBindingSource.DataSource = this.maindataset.bill;
            this.mainbillBindingSource.DataSource = this.maindataset.mainbill;
            reportViewer1.RefreshReport();
        }
    }
}